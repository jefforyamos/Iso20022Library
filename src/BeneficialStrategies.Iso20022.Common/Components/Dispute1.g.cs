﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Dispute1.  ISO2002 ID# _Ulb4Ftp-Ed-ak6NoX_4Aeg_1250324083.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the dispute details.
/// </summary>
public partial record Dispute1
     : IIsoXmlSerilizable<Dispute1>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification for the margin call request.
    /// </summary>
    public required IsoMax35Text MarginCallRequestIdentification { get; init; } 
    /// <summary>
    /// Disputed amount.
    /// </summary>
    public required IsoActiveCurrencyAndAmount DisputedAmount { get; init; } 
    /// <summary>
    /// Date of dispute.
    /// </summary>
    public required IsoISODate DisputeDate { get; init; } 
    
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
        writer.WriteStartElement(null, "MrgnCallReqId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(MarginCallRequestIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DsptdAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(DisputedAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "DsptDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(DisputeDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
    }
    public static Dispute1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
