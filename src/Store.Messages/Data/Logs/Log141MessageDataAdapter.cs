//----------------------------------------------------------------------- 
// PDS WITSMLstudio Store, 2018.3
//
// Copyright 2018 PDS Americas LLC
// 
// Licensed under the PDS Open Source WITSML Product License Agreement (the
// "License"); you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   
//     http://www.pds.group/WITSMLstudio/OpenSource/ProductLicenseAgreement
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

// ----------------------------------------------------------------------
// <auto-generated>
//     Changes to this file may cause incorrect behavior and will be lost
//     if the code is regenerated.
// </auto-generated>
// ----------------------------------------------------------------------
using System.ComponentModel.Composition;
using Energistics.DataAccess.WITSML141;
using PDS.WITSMLstudio.Framework;
using PDS.WITSMLstudio.Store.Configuration;

namespace PDS.WITSMLstudio.Store.Data.Logs
{
    /// <summary>
    /// Data adapter that encapsulates CRUD functionality for <see cref="Log" />
    /// </summary>
    /// <seealso cref="PDS.WITSMLstudio.Store.Data.MessageDataAdapter{Log}" />
    /// <seealso cref="PDS.WITSMLstudio.Store.Configuration.IWitsml141Configuration" />
    [Export(typeof(IWitsml141Configuration))]
    [Export(typeof(IWitsmlDataAdapter<Log>))]
    [Export141(ObjectTypes.Log, typeof(IWitsmlDataAdapter))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class Log141MessageDataAdapter : MessageDataAdapter<Log>, IWitsml141Configuration    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Log141MessageDataAdapter" /> class.
        /// </summary>
        /// <param name="container">The composition container.</param>
        [ImportingConstructor]
        public Log141MessageDataAdapter(IContainer container)
            : base(container, ObjectNames.Log141)
        {
            Logger.Verbose("Instance created.");
        }

        /// <summary>
        /// Gets the supported capabilities for the <see cref="Log"/> object.
        /// </summary>
        /// <param name="capServer">The capServer instance.</param>
        public void GetCapabilities(CapServer capServer)
        {
            Logger.DebugFormat("Getting the supported capabilities for Log data version {0}.", capServer.Version);

            if (MessageHandler.IsQueryEnabled)
                capServer.Add(Functions.GetFromStore, ObjectTypes.Log, WitsmlSettings.LogMaxDataNodesGet, WitsmlSettings.LogMaxDataPointsGet);

            capServer.Add(Functions.AddToStore, ObjectTypes.Log, WitsmlSettings.LogMaxDataNodesAdd, WitsmlSettings.LogMaxDataPointsAdd);
            capServer.Add(Functions.UpdateInStore, ObjectTypes.Log, WitsmlSettings.LogMaxDataNodesUpdate, WitsmlSettings.LogMaxDataPointsUpdate);
            //capServer.Add(Functions.DeleteFromStore, ObjectTypes.Log, WitsmlSettings.LogMaxDataNodesDelete, WitsmlSettings.LogMaxDataPointsDelete);
            capServer.SetGrowingTimeoutPeriod(ObjectTypes.Log, WitsmlSettings.LogGrowingTimeoutPeriod);
      }
    }
}