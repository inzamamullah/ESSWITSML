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

using WbGeometry = Energistics.DataAccess.WITSML141.StandAloneWellboreGeometry;
using WbGeometryList = Energistics.DataAccess.WITSML141.WellboreGeometryList;

namespace PDS.WITSMLstudio.Store.Data.WbGeometries
{
    /// <summary>
    /// Provides validation for <see cref="WbGeometry" /> data objects.
    /// </summary>
    /// <seealso cref="PDS.WITSMLstudio.Store.Data.DataObjectValidator{WbGeometry}" />
    [Export(typeof(IDataObjectValidator<WbGeometry>))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class WbGeometry141Validator : WellboreDataObjectValidator<WbGeometry, Wellbore, Well>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WbGeometry141Validator" /> class.
        /// </summary>
        /// <param name="container">The composition container.</param>
        /// <param name="wbGeometryDataAdapter">The wbGeometry data adapter.</param>
        /// <param name="wellboreDataAdapter">The wellbore data adapter.</param>
        /// <param name="wellDataAdapter">The well data adapter.</param>
        [ImportingConstructor]
        public WbGeometry141Validator(
            IContainer container,
            IWitsmlDataAdapter<WbGeometry> wbGeometryDataAdapter,
            IWitsmlDataAdapter<Wellbore> wellboreDataAdapter,
            IWitsmlDataAdapter<Well> wellDataAdapter)
            : base(container, wbGeometryDataAdapter, wellboreDataAdapter, wellDataAdapter)
        {
        }
    }
}