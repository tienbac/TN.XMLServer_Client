using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TN.XMLServer_Client.Code
{
    class Alams
    {
    }


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class CitiAnswer
    {

        private CitiAnswerAlarm[] alarmField;

        private string typeField;

        private byte idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Alarm")]
        public CitiAnswerAlarm[] Alarm
        {
            get
            {
                return this.alarmField;
            }
            set
            {
                this.alarmField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CitiAnswerAlarm
    {

        private string typeField;

        private string cameraNameField;

        private byte cameraIdField;

        private byte laneIdField;

        private string startTimeField;

        private string endTimeField;

        private object commentField;

        private sbyte rowRatioField;

        private sbyte columnRatioField;

        private CitiAnswerAlarmExtraAlarmData extraAlarmDataField;

        private byte idField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string CameraName
        {
            get
            {
                return this.cameraNameField;
            }
            set
            {
                this.cameraNameField = value;
            }
        }

        /// <remarks/>
        public byte CameraId
        {
            get
            {
                return this.cameraIdField;
            }
            set
            {
                this.cameraIdField = value;
            }
        }

        /// <remarks/>
        public byte LaneId
        {
            get
            {
                return this.laneIdField;
            }
            set
            {
                this.laneIdField = value;
            }
        }

        /// <remarks/>
        public string StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        public string EndTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }

        /// <remarks/>
        public object Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        public sbyte RowRatio
        {
            get
            {
                return this.rowRatioField;
            }
            set
            {
                this.rowRatioField = value;
            }
        }

        /// <remarks/>
        public sbyte ColumnRatio
        {
            get
            {
                return this.columnRatioField;
            }
            set
            {
                this.columnRatioField = value;
            }
        }

        /// <remarks/>
        public CitiAnswerAlarmExtraAlarmData ExtraAlarmData
        {
            get
            {
                return this.extraAlarmDataField;
            }
            set
            {
                this.extraAlarmDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CitiAnswerAlarmExtraAlarmData
    {

        private byte dangerField;

        private ushort materialField;

        private sbyte reliabilityField;

        /// <remarks/>
        public byte Danger
        {
            get
            {
                return this.dangerField;
            }
            set
            {
                this.dangerField = value;
            }
        }

        /// <remarks/>
        public ushort Material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        /// <remarks/>
        public sbyte Reliability
        {
            get
            {
                return this.reliabilityField;
            }
            set
            {
                this.reliabilityField = value;
            }
        }
    }



    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class CitiEvent
    {

        private CitiEventAlarm alarmField;

        private string typeField;

        /// <remarks/>
        public CitiEventAlarm Alarm
        {
            get
            {
                return this.alarmField;
            }
            set
            {
                this.alarmField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CitiEventAlarm
    {

        private string typeField;

        private string cameraNameField;

        private byte cameraIdField;

        private byte laneIdField;

        private string startTimeField;

        private string endTimeField;

        private object commentField;

        private sbyte rowRatioField;

        private sbyte columnRatioField;

        private CitiEventAlarmExtraAlarmData extraAlarmDataField;

        private byte idField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string CameraName
        {
            get
            {
                return this.cameraNameField;
            }
            set
            {
                this.cameraNameField = value;
            }
        }

        /// <remarks/>
        public byte CameraId
        {
            get
            {
                return this.cameraIdField;
            }
            set
            {
                this.cameraIdField = value;
            }
        }

        /// <remarks/>
        public byte LaneId
        {
            get
            {
                return this.laneIdField;
            }
            set
            {
                this.laneIdField = value;
            }
        }

        /// <remarks/>
        public string StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        public string EndTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }

        /// <remarks/>
        public object Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        public sbyte RowRatio
        {
            get
            {
                return this.rowRatioField;
            }
            set
            {
                this.rowRatioField = value;
            }
        }

        /// <remarks/>
        public sbyte ColumnRatio
        {
            get
            {
                return this.columnRatioField;
            }
            set
            {
                this.columnRatioField = value;
            }
        }

        /// <remarks/>
        public CitiEventAlarmExtraAlarmData ExtraAlarmData
        {
            get
            {
                return this.extraAlarmDataField;
            }
            set
            {
                this.extraAlarmDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CitiEventAlarmExtraAlarmData
    {

        private byte dangerField;

        private ushort materialField;

        private sbyte reliabilityField;

        /// <remarks/>
        public byte Danger
        {
            get
            {
                return this.dangerField;
            }
            set
            {
                this.dangerField = value;
            }
        }

        /// <remarks/>
        public ushort Material
        {
            get
            {
                return this.materialField;
            }
            set
            {
                this.materialField = value;
            }
        }

        /// <remarks/>
        public sbyte Reliability
        {
            get
            {
                return this.reliabilityField;
            }
            set
            {
                this.reliabilityField = value;
            }
        }
    }


}
