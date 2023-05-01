/*
' Copyright (c) 2023 WhimsicalWares
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;
using System.Collections.Generic;

namespace fITness.Dnn.Dnn.fITness.HelloWorld.Components
{
    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for Dnn.fITness.HelloWorld
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<Dnn.fITness.HelloWorldInfo> colDnn.fITness.HelloWorlds = GetDnn.fITness.HelloWorlds(ModuleID);
        //if (colDnn.fITness.HelloWorlds.Count != 0)
        //{
        //    strXML += "<Dnn.fITness.HelloWorlds>";

        //    foreach (Dnn.fITness.HelloWorldInfo objDnn.fITness.HelloWorld in colDnn.fITness.HelloWorlds)
        //    {
        //        strXML += "<Dnn.fITness.HelloWorld>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objDnn.fITness.HelloWorld.Content) + "</content>";
        //        strXML += "</Dnn.fITness.HelloWorld>";
        //    }
        //    strXML += "</Dnn.fITness.HelloWorlds>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlDnn.fITness.HelloWorlds = DotNetNuke.Common.Globals.GetContent(Content, "Dnn.fITness.HelloWorlds");
        //foreach (XmlNode xmlDnn.fITness.HelloWorld in xmlDnn.fITness.HelloWorlds.SelectNodes("Dnn.fITness.HelloWorld"))
        //{
        //    Dnn.fITness.HelloWorldInfo objDnn.fITness.HelloWorld = new Dnn.fITness.HelloWorldInfo();
        //    objDnn.fITness.HelloWorld.ModuleId = ModuleID;
        //    objDnn.fITness.HelloWorld.Content = xmlDnn.fITness.HelloWorld.SelectSingleNode("content").InnerText;
        //    objDnn.fITness.HelloWorld.CreatedByUser = UserID;
        //    AddDnn.fITness.HelloWorld(objDnn.fITness.HelloWorld);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<Dnn.fITness.HelloWorldInfo> colDnn.fITness.HelloWorlds = GetDnn.fITness.HelloWorlds(ModInfo.ModuleID);

        //foreach (Dnn.fITness.HelloWorldInfo objDnn.fITness.HelloWorld in colDnn.fITness.HelloWorlds)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objDnn.fITness.HelloWorld.Content, objDnn.fITness.HelloWorld.CreatedByUser, objDnn.fITness.HelloWorld.CreatedDate, ModInfo.ModuleID, objDnn.fITness.HelloWorld.ItemId.ToString(), objDnn.fITness.HelloWorld.Content, "ItemId=" + objDnn.fITness.HelloWorld.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}
