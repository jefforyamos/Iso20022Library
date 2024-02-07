﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate54.  ISO2002 ID# _ctZv5ZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
public partial record CorporateActionDate54
     : IIsoXmlSerilizable<CorporateActionDate54>
{
    #nullable enable
    
    /// <summary>
    /// Date/time at which positions are struck at the end of the day to note which parties will receive the relevant amount of entitlement, due to be distributed on payment date.
    /// </summary>
    public DateFormat34Choice_? RecordDate { get; init; } 
    /// <summary>
    /// Date/time as from which trading (including exchange and OTC trading) occurs on the underlying security without the benefit.
    /// </summary>
    public DateFormat34Choice_? ExDividendDate { get; init; } 
    /// <summary>
    /// Date/time on which the lottery is run and applied to the holder's positions. This is also applicable to partial calls.
    /// </summary>
    public DateFormat34Choice_? LotteryDate { get; init; } 
    
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
        if (RecordDate is DateFormat34Choice_ RecordDateValue)
        {
            writer.WriteStartElement(null, "RcrdDt", xmlNamespace );
            RecordDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExDividendDate is DateFormat34Choice_ ExDividendDateValue)
        {
            writer.WriteStartElement(null, "ExDvddDt", xmlNamespace );
            ExDividendDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LotteryDate is DateFormat34Choice_ LotteryDateValue)
        {
            writer.WriteStartElement(null, "LtryDt", xmlNamespace );
            LotteryDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionDate54 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
