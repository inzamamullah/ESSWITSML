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
using Energistics.DataAccess.WITSML131;
using PDS.WITSMLstudio.Framework;
using PDS.WITSMLstudio.Store.Configuration;

namespace PDS.WITSMLstudio.Store.Data.WellLogs
{
    /// <summary>
    /// Data adapter that encapsulates CRUD functionality for <see cref="WellLog" />
    /// </summary>
    /// <seealso cref="PDS.WITSMLstudio.Store.Data.MessageDataAdapter{WellLog}" />
    /// <seealso cref="PDS.WITSMLstudio.Store.Configuration.IWitsml131Configuration" />
    [Export(typeof(IWitsml131Configuration))]
    [Export(typeof(IWitsmlDataAdapter<WellLog>))]
    [Export131(ObjectTypes.WellLog, typeof(IWitsmlDataAdapter))]
    [PartCreationPolicy(CreationPolicy.Shared)]
    public class WellLog131MessageDataAdapter : MessageDataAdapter<WellLog>, IWitsml131Configuration    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WellLog131MessageDataAdapter" /> class.
        /// </summary>
        /// <param name="container">The composition container.</param>
        [ImportingConstructor]
        public WellLog131MessageDataAdapter(IContainer container)
            : base(container, ObjectNames.WellLog131)
        {
            Logger.Verbose("Instance created.");
        }

        /// <summary>
        /// Gets the supported capabilities for the <see cref="WellLog"/> object.
        /// </summary>
        /// <param name="capServer">The capServer instance.</param>
        public void GetCapabilities(CapServer capServer)
        {
            Logger.DebugFormat("Getting the supported capabilities for WellLog data version {0}.", capServer.Version);

            if (MessageHandler.IsQueryEnabled)
                capServer.Add(Functions.GetFromStore, ObjectTypes.WellLog);

            capServer.Add(Functions.AddToStore, ObjectTypes.WellLog);
            capServer.Add(Functions.UpdateInStore, ObjectTypes.WellLog);
            //capServer.Add(Functions.DeleteFromStore, ObjectTypes.WellLog);
      }
    }
}