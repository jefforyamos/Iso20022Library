﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Schedule11.  ISO2002 ID# _6XkwkT3XEe2uHKhHp3bXyA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates the unadjusted effective and end date of the schedule.
/// </summary>
public partial record Schedule11
     : IIsoXmlSerilizable<Schedule11>
{
    #nullable enable
    
    /// <summary>
    /// Indicates the unadjusted date at which obligations under the  derivative transaction come into effect, as included in the confirmation.
    /// </summary>
    public required IsoISODate UnadjustedEffectiveDate { get; init; } 
    /// <summary>
    /// Indicates the end date agreed in the derivative transaction without adjustment.
    /// </summary>
    public IsoISODate? UnadjustedEndDate { get; init; } 
    /// <summary>
    /// Indicates the price per derivative excluding, where applicable, commission and accrued interest.
    /// </summary>
    public required AmountAndDirection106 Amount { get; init; } 
    
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
        writer.WriteStartElement(null, "UadjstdFctvDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(UnadjustedEffectiveDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (UnadjustedEndDate is IsoISODate UnadjustedEndDateValue)
        {
            writer.WriteStartElement(null, "UadjstdEndDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(UnadjustedEndDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        Amount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static Schedule11 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
