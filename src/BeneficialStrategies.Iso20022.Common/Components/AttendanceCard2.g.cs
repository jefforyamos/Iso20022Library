﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AttendanceCard2.  ISO2002 ID# _TiranNp-Ed-ak6NoX_4Aeg_-1547572395.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies details related to the attendance card.
/// </summary>
public partial record AttendanceCard2
     : IIsoXmlSerilizable<AttendanceCard2>
{
    #nullable enable
    
    /// <summary>
    /// Information to be indicated on the attendance card.
    /// </summary>
    public IsoMax105Text? AttendanceCardLabelling { get; init; } 
    /// <summary>
    /// Specifies where the attendance card must be delivered.
    /// </summary>
    public required DeliveryPlace1Code DeliveryMethod { get; init; } 
    /// <summary>
    /// Name and address of a party.
    /// </summary>
    public NameAndAddress9? OtherAddress { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (AttendanceCardLabelling is IsoMax105Text AttendanceCardLabellingValue)
        {
            writer.WriteStartElement(null, "AttndncCardLbllg", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax105Text(AttendanceCardLabellingValue)); // data type Max105Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DlvryMtd", xmlNamespace );
        writer.WriteValue(DeliveryMethod.ToString()); // Enum value
        writer.WriteEndElement();
        if (OtherAddress is NameAndAddress9 OtherAddressValue)
        {
            writer.WriteStartElement(null, "OthrAdr", xmlNamespace );
            OtherAddressValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AttendanceCard2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
