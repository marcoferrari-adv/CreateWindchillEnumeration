using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CreateWindchillEnumeration
{
    internal class WindchillEnumerationLoaderBuilder
    {

        private WindchillEnumerationRequest request;

        public WindchillEnumerationLoaderBuilder(WindchillEnumerationRequest request)
        {
            this.request = request;
        }


        public void Save(string path)
        {
            XmlDocument doc = new XmlDocument();
            XmlDocumentType docType = doc.CreateDocumentType("NmLoader", null, "standardX24.dtd", null);
            doc.AppendChild(docType);

            XmlElement rootNode = doc.CreateElement("NmLoader");

            doc.AppendChild(rootNode);

            XmlElement csvBeginEnumDefView = doc.CreateElement("csvBeginEnumDefView");
            csvBeginEnumDefView.SetAttribute("handler", "com.ptc.core.lwc.server.BaseDefinitionLoader.beginProcessEnumerationDefinition");
            rootNode.AppendChild(csvBeginEnumDefView);

            XmlElement csvName = doc.CreateElement("csvname");
            csvName.InnerText = request.InternalNameEnum;
            csvBeginEnumDefView.AppendChild(csvName);

            XmlElement csvcontainerDomain = doc.CreateElement("csvcontainerDomain");
            csvcontainerDomain.InnerText = request.ContainerDomain;
            csvBeginEnumDefView.AppendChild(csvcontainerDomain);

            XmlElement csvMaster = doc.CreateElement("csvmaster");
            csvBeginEnumDefView.AppendChild(csvcontainerDomain);

            XmlElement csvSystem = doc.CreateElement("csvsystem");
            csvSystem.InnerText = "false";
            csvBeginEnumDefView.AppendChild(csvSystem);

            XmlElement csvOrganizer = doc.CreateElement("csvorganizer");
            csvOrganizer.InnerText = request.OrganizerName;
            csvBeginEnumDefView.AppendChild(csvOrganizer);

            XmlElement csvdomainRef = doc.CreateElement("csvdomainRef");
            csvdomainRef.InnerText = "/System";
            csvBeginEnumDefView.AppendChild(csvdomainRef);

            createEnumDefinitionProperty(doc, rootNode, "displayName", request.ValueDisplayName, true);
            createEnumDefinitionProperty(doc, rootNode, "description", request.ValueDisplayName, true);
            createEnumDefinitionProperty(doc, rootNode, "tooltip", request.ValueDisplayName, true);
            createEnumDefinitionProperty(doc, rootNode, "autoSort", request.ValueSort.ToString(), false);

            foreach (Dictionary<string, object> row in request.TableRows)
            {
                createEnumMembership(doc, rootNode, row);
            }

            XmlElement csvEndEnumDefView = doc.CreateElement("csvEndEnumDefView");
            csvEndEnumDefView.SetAttribute("handler", "com.ptc.core.lwc.server.BaseDefinitionLoader.endProcessEnumerationDefinition");
            rootNode.AppendChild(csvEndEnumDefView);

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(path, settings))
            {
                doc.Save(writer);
            }
        }

        private void createEnumDefinitionProperty(XmlDocument doc, XmlElement parentNode, string name, string value, Boolean localizable)
        {
            XmlElement csvPropertyValue = doc.CreateElement("csvPropertyValue");
            csvPropertyValue.SetAttribute("handler", "com.ptc.core.lwc.server.BaseDefinitionLoader.processEnumerationPropertyValue");
            parentNode.AppendChild(csvPropertyValue);

            XmlElement csvname = doc.CreateElement("csvname");
            csvname.InnerText = name;
            csvPropertyValue.AppendChild(csvname);

            XmlElement csvvalue = doc.CreateElement("csvvalue");
            csvvalue.InnerText = value;
            csvPropertyValue.AppendChild(csvvalue);

            if (localizable)
            {
                //TODO handle localization
            }
        }

        private void createEnumMembership(XmlDocument doc, XmlElement parentNode, Dictionary<string, object> membership)
        {

            string name = membership["InternalValue"] as string;
            string value = membership["MasterText"] as string;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(value))
                return;

            XmlElement csvBeginEnumMemberView = doc.CreateElement("csvBeginEnumMemberView");
            csvBeginEnumMemberView.SetAttribute("handler", "com.ptc.core.lwc.server.BaseDefinitionLoader.beginProcessEnumMembership");
            parentNode.AppendChild(csvBeginEnumMemberView);

            XmlElement csvname = doc.CreateElement("csvname");
            csvname.InnerText = name;
            csvBeginEnumMemberView.AppendChild(csvname);

            XmlElement csvPropertyValue = doc.CreateElement("csvPropertyValue");
            csvPropertyValue.SetAttribute("handler", "com.ptc.core.lwc.server.BaseDefinitionLoader.processEnumEntryPropertyValue");
            parentNode.AppendChild(csvPropertyValue);

            XmlElement csvnamePropValue = doc.CreateElement("csvname");
            csvnamePropValue.InnerText = "displayName";
            csvPropertyValue.AppendChild(csvnamePropValue);

            XmlElement csvisDefault = doc.CreateElement("csvisDefault");
            csvisDefault.InnerText = "false";
            csvPropertyValue.AppendChild(csvisDefault);

            XmlElement csvvalue = doc.CreateElement("csvvalue");
            csvvalue.InnerText = value;
            csvPropertyValue.AppendChild(csvvalue);

            foreach(var member in membership.Where(pair => pair.Key.StartsWith("Display_"))){
                string key = member.Key.Substring(member.Key.IndexOf("_") + 1);
                string memberValue = member.Value as string;
                if (string.IsNullOrEmpty(memberValue))
                    continue;

                XmlElement csvLocaleValue = doc.CreateElement($"csvlocale_{key.ToLower()}");
                csvLocaleValue.InnerText = memberValue;
                csvPropertyValue.AppendChild(csvLocaleValue);
            }


            XmlElement csvEndEnumMemberView = doc.CreateElement("csvEndEnumMemberView");
            csvEndEnumMemberView.SetAttribute("handler", "com.ptc.core.lwc.server.BaseDefinitionLoader.endProcessEnumMembership");
            parentNode.AppendChild(csvEndEnumMemberView);
        }
    }
}
