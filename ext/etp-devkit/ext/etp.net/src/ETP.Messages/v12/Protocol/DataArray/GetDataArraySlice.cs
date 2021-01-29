// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.DataArray
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GetDataArraySlice : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""GetDataArraySlice"",""namespace"":""Energistics.Etp.v12.Protocol.DataArray"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""pathInResource"",""type"":""string""},{""name"":""starts"",""default"":[],""type"":{""type"":""array"",""items"":""long""}},{""name"":""counts"",""default"":[],""type"":{""type"":""array"",""items"":""long""}}],""protocol"":""9"",""messageType"":""3"",""senderRole"":""customer"",""protocolRoles"":""store,customer"",""multipartFlag"":false,""fullName"":""Energistics.Etp.v12.Protocol.DataArray.GetDataArraySlice"",""depends"":[]}");
		private string _uri;
		private string _pathInResource;
		private IList<System.Int64> _starts;
		private IList<System.Int64> _counts;
		public virtual Schema Schema
		{
			get
			{
				return GetDataArraySlice._SCHEMA;
			}
		}
		public string Uri
		{
			get
			{
				return this._uri;
			}
			set
			{
				this._uri = value;
			}
		}
		public string PathInResource
		{
			get
			{
				return this._pathInResource;
			}
			set
			{
				this._pathInResource = value;
			}
		}
		public IList<System.Int64> Starts
		{
			get
			{
				return this._starts;
			}
			set
			{
				this._starts = value;
			}
		}
		public IList<System.Int64> Counts
		{
			get
			{
				return this._counts;
			}
			set
			{
				this._counts = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uri;
			case 1: return this._pathInResource;
			case 2: return this._starts;
			case 3: return this._counts;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uri = (System.String)fieldValue; break;
			case 1: this._pathInResource = (System.String)fieldValue; break;
			case 2: this._starts = (IList<System.Int64>)fieldValue; break;
			case 3: this._counts = (IList<System.Int64>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}