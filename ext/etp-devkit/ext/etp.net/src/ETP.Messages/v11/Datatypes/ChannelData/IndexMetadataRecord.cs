// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v11.Datatypes.ChannelData
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class IndexMetadataRecord : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"IndexMetadataRecord\",\"namespace\":\"Energistics.Datatypes." +
				"ChannelData\",\"fields\":[{\"name\":\"indexType\",\"type\":{\"type\":\"enum\",\"name\":\"Channel" +
				"IndexTypes\",\"namespace\":\"Energistics.Datatypes.ChannelData\",\"symbols\":[\"Time\",\"D" +
				"epth\"],\"fullName\":\"Energistics.Datatypes.ChannelData.ChannelIndexTypes\",\"depends" +
				"\":[]}},{\"name\":\"uom\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"type\":[\"null\",\"strin" +
				"g\"]},{\"name\":\"direction\",\"type\":{\"type\":\"enum\",\"name\":\"IndexDirections\",\"namespa" +
				"ce\":\"Energistics.Datatypes.ChannelData\",\"symbols\":[\"Increasing\",\"Decreasing\"],\"f" +
				"ullName\":\"Energistics.Datatypes.ChannelData.IndexDirections\",\"depends\":[]}},{\"na" +
				"me\":\"mnemonic\",\"type\":[\"null\",\"string\"]},{\"name\":\"description\",\"type\":[\"null\",\"s" +
				"tring\"]},{\"name\":\"uri\",\"type\":[\"null\",\"string\"]},{\"name\":\"customData\",\"type\":{\"t" +
				"ype\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"DataValue\",\"namespace\":\"Energistics" +
				".Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"double\",\"float\",\"int\",\"long" +
				"\",\"string\",{\"type\":\"record\",\"name\":\"ArrayOfDouble\",\"namespace\":\"Energistics.Data" +
				"types\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}],\"fu" +
				"llName\":\"Energistics.Datatypes.ArrayOfDouble\",\"depends\":[]},\"boolean\",\"bytes\"]}]" +
				",\"fullName\":\"Energistics.Datatypes.DataValue\",\"depends\":[\r\n  \"Energistics.Dataty" +
				"pes.ArrayOfDouble\"\r\n]}}},{\"name\":\"scale\",\"type\":\"int\"},{\"name\":\"timeDatum\",\"type" +
				"\":[\"null\",\"string\"]}],\"fullName\":\"Energistics.Datatypes.ChannelData.IndexMetadat" +
				"aRecord\",\"depends\":[\r\n  \"Energistics.Datatypes.ChannelData.ChannelIndexTypes\",\r\n" +
				"  \"Energistics.Datatypes.ChannelData.IndexDirections\",\r\n  \"Energistics.Datatypes" +
				".DataValue\"\r\n]}");
		private Energistics.Etp.v11.Datatypes.ChannelData.ChannelIndexTypes _indexType;
		private string _uom;
		private string _depthDatum;
		private Energistics.Etp.v11.Datatypes.ChannelData.IndexDirections _direction;
		private string _mnemonic;
		private string _description;
		private string _uri;
		private IDictionary<string,Energistics.Etp.v11.Datatypes.DataValue> _customData;
		private int _scale;
		private string _timeDatum;
		public virtual Schema Schema
		{
			get
			{
				return IndexMetadataRecord._SCHEMA;
			}
		}
		public Energistics.Etp.v11.Datatypes.ChannelData.ChannelIndexTypes IndexType
		{
			get
			{
				return this._indexType;
			}
			set
			{
				this._indexType = value;
			}
		}
		public string Uom
		{
			get
			{
				return this._uom;
			}
			set
			{
				this._uom = value;
			}
		}
		public string DepthDatum
		{
			get
			{
				return this._depthDatum;
			}
			set
			{
				this._depthDatum = value;
			}
		}
		public Energistics.Etp.v11.Datatypes.ChannelData.IndexDirections Direction
		{
			get
			{
				return this._direction;
			}
			set
			{
				this._direction = value;
			}
		}
		public string Mnemonic
		{
			get
			{
				return this._mnemonic;
			}
			set
			{
				this._mnemonic = value;
			}
		}
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				this._description = value;
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
		public IDictionary<string,Energistics.Etp.v11.Datatypes.DataValue> CustomData
		{
			get
			{
				return this._customData;
			}
			set
			{
				this._customData = value;
			}
		}
		public int Scale
		{
			get
			{
				return this._scale;
			}
			set
			{
				this._scale = value;
			}
		}
		public string TimeDatum
		{
			get
			{
				return this._timeDatum;
			}
			set
			{
				this._timeDatum = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._indexType;
			case 1: return this._uom;
			case 2: return this._depthDatum;
			case 3: return this._direction;
			case 4: return this._mnemonic;
			case 5: return this._description;
			case 6: return this._uri;
			case 7: return this._customData;
			case 8: return this._scale;
			case 9: return this._timeDatum;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._indexType = (Energistics.Etp.v11.Datatypes.ChannelData.ChannelIndexTypes)fieldValue; break;
			case 1: this._uom = (System.String)fieldValue; break;
			case 2: this._depthDatum = (System.String)fieldValue; break;
			case 3: this._direction = (Energistics.Etp.v11.Datatypes.ChannelData.IndexDirections)fieldValue; break;
			case 4: this._mnemonic = (System.String)fieldValue; break;
			case 5: this._description = (System.String)fieldValue; break;
			case 6: this._uri = (System.String)fieldValue; break;
			case 7: this._customData = (IDictionary<string,Energistics.Etp.v11.Datatypes.DataValue>)fieldValue; break;
			case 8: this._scale = (System.Int32)fieldValue; break;
			case 9: this._timeDatum = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
