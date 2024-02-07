﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionSD9.  ISO2002 ID# _VIg5E2JWEeOfOt7Y7nAPUA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action details.
/// </summary>
public partial record CorporateActionSD9
     : IIsoXmlSerilizable<CorporateActionSD9>
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Date at which positions are stuck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date. DTC (The Depository Trust Corporation) and its Participants may use this as a reference.
    /// </summary>
    public IsoISODate? RecordDate { get; init; } 
    /// <summary>
    /// Date/time at which the movement was due to take place (cash and/or securities).
    /// </summary>
    public DateFormat28Choice_? PaymentDate { get; init; } 
    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder's positions. This is also applicable to partial calls.
    /// </summary>
    public IsoISODate? LotteryDate { get; init; } 
    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    public LotteryType1Code? LotteryType { get; init; } 
    
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
        writer.WriteStartElement(null, "PlcAndNm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax350Text(PlaceAndName)); // data type Max350Text System.String
        writer.WriteEndElement();
        if (RecordDate is IsoISODate RecordDateValue)
        {
            writer.WriteStartElement(null, "RcrdDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(RecordDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (PaymentDate is DateFormat28Choice_ PaymentDateValue)
        {
            writer.WriteStartElement(null, "PmtDt", xmlNamespace );
            PaymentDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LotteryDate is IsoISODate LotteryDateValue)
        {
            writer.WriteStartElement(null, "LtryDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(LotteryDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (LotteryType is LotteryType1Code LotteryTypeValue)
        {
            writer.WriteStartElement(null, "LtryTp", xmlNamespace );
            writer.WriteValue(LotteryTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static CorporateActionSD9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
