﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Reinvestment3.  ISO2002 ID# _J1SUgU_dEeaB8-OWTiMVrQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reinvestment information.
/// </summary>
public partial record Reinvestment3
     : IIsoXmlSerilizable<Reinvestment3>
{
    #nullable enable
    
    /// <summary>
    /// Investment fund for the reinvestment.
    /// </summary>
    public required FinancialInstrument56 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    public ActiveCurrencyCode? RequestedNAVCurrency { get; init; } 
    /// <summary>
    /// Percentage of the reinvestment.
    /// </summary>
    public required IsoPercentageRate ReinvestmentPercentage { get; init; } 
    
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
        writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
        FinancialInstrumentDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (RequestedNAVCurrency is ActiveCurrencyCode RequestedNAVCurrencyValue)
        {
            writer.WriteStartElement(null, "ReqdNAVCcy", xmlNamespace );
            writer.WriteValue(RequestedNAVCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RinvstmtPctg", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoPercentageRate(ReinvestmentPercentage)); // data type PercentageRate System.Decimal
        writer.WriteEndElement();
    }
    public static Reinvestment3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
