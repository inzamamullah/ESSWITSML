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

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Energistics.DataAccess;
using Energistics.DataAccess.WITSML200;
using Energistics.DataAccess.WITSML200.ComponentSchemas;
using Energistics.DataAccess.WITSML200.ReferenceData;
using Energistics.Etp;
using Energistics.Etp.Common;
using Energistics.Etp.v11.Protocol;
using Energistics.Etp.v11.Protocol.Core;
using Energistics.Etp.v11.Protocol.Discovery;
using Energistics.Etp.v11.Protocol.Store;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PDS.WITSMLstudio.Store.Data.Activities
{
    [TestClass]
    public partial class Activity200EtpTests : Activity200TestBase
    {
        public Activity200EtpTests()
            : base(true)
        {
        }

        [TestMethod]
        public void Activity200_Ensure_Creates_Activity_With_Default_Values()
        {
            DevKit.EnsureAndAssert(Activity);
        }

        [TestMethod]
        public async Task Activity200_GetResources_Can_Get_All_Activity_Resources()
        {
            AddParents();
            DevKit.AddAndAssert(Activity);
            await RequestSessionAndAssert();

            var uri = Activity.GetUri();
            var parentUri = uri.Parent;

            var folderUri = parentUri.Append(uri.ObjectType);
            await GetResourcesAndAssert(folderUri);
        }

        [TestMethod]
        public async Task Activity200_PutObject_Can_Add_Activity()
        {
            AddParents();
            await RequestSessionAndAssert();

            var handler = _client.Handler<IStoreCustomer>();
            var uri = Activity.GetUri();

            var dataObject = CreateDataObject(uri, Activity);

            // Get Object Expecting it Not to Exist
            await GetAndAssert(handler, uri, Energistics.Etp.EtpErrorCodes.NotFound);

            // Put Object
            await PutAndAssert(handler, dataObject);

            // Get Object
            var args = await GetAndAssert(handler, uri);

            // Check Data Object XML
            Assert.IsNotNull(args?.Message.DataObject);
            var xml = args.Message.DataObject.GetString();

            var result = Parse<Activity>(xml);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task Activity200_PutObject_Can_Update_Activity()
        {
            AddParents();
            await RequestSessionAndAssert();

            var handler = _client.Handler<IStoreCustomer>();
            var uri = Activity.GetUri();

            // Add a ExtensionNameValue to Data Object
            var envName = "TestPutObject";
            var env = DevKit.ExtensionNameValue(envName, envName);
            Activity.ExtensionNameValue = new List<ExtensionNameValue>() {env};

            var dataObject = CreateDataObject(uri, Activity);

            // Get Object Expecting it Not to Exist
            await GetAndAssert(handler, uri, Energistics.Etp.EtpErrorCodes.NotFound);

            // Put Object for Add
            await PutAndAssert(handler, dataObject);

            // Get Added Object
            var args =await GetAndAssert(handler, uri);

            // Check Added Data Object XML
            Assert.IsNotNull(args?.Message.DataObject);
            var xml = args.Message.DataObject.GetString();

            var result = Parse<Activity>(xml);
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ExtensionNameValue.FirstOrDefault(e => e.Name.Equals(envName)));

            // Remove Comment from Data Object
            result.ExtensionNameValue.Clear();

            var updateDataObject = CreateDataObject(uri, result);

            // Put Object for Update
            await PutAndAssert(handler, updateDataObject);

            // Get Updated Object
            args = await GetAndAssert(handler, uri);

            // Check Added Data Object XML
            Assert.IsNotNull(args?.Message.DataObject);
            var updateXml = args.Message.DataObject.GetString();

            result = Parse<Activity>(updateXml);
            Assert.IsNotNull(result);

            // Test Data Object overwrite
            Assert.IsNull(result.ExtensionNameValue.FirstOrDefault(e => e.Name.Equals(envName)));
        }

        [TestMethod]
        public async Task Activity200_DeleteObject_Can_Delete_Activity()
        {
            AddParents();
            await RequestSessionAndAssert();

            var handler = _client.Handler<IStoreCustomer>();
            var uri = Activity.GetUri();

            var dataObject = CreateDataObject(uri, Activity);

            // Get Object Expecting it Not to Exist
            await GetAndAssert(handler, uri, Energistics.Etp.EtpErrorCodes.NotFound);

            // Put Object
            await PutAndAssert(handler, dataObject);

            // Get Object
            var args = await GetAndAssert(handler, uri);

            // Check Data Object XML
            Assert.IsNotNull(args?.Message.DataObject);
            var xml = args.Message.DataObject.GetString();

            var result = Parse<Activity>(xml);
            Assert.IsNotNull(result);

            // Delete Object
            await DeleteAndAssert(handler, uri);

            // Get Object Expecting it Not to Exist
            await GetAndAssert(handler, uri, Energistics.Etp.EtpErrorCodes.NotFound);
        }
    }
}