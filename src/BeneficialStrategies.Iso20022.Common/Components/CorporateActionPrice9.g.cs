﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPrice9.  ISO2002 ID# _TWKoktp-Ed-ak6NoX_4Aeg_313474067.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices.
/// </summary>
public partial record CorporateActionPrice9
     : IIsoXmlSerilizable<CorporateActionPrice9>
{
    #nullable enable
    
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    public PriceFormat5Choice_? CashInLieuOfSharePrice { get; init; } 
    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    public IndicativeOrMarketPrice2Choice_? IndicativeOrMarketPrice { get; init; } 
    
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
        if (CashInLieuOfSharePrice is PriceFormat5Choice_ CashInLieuOfSharePriceValue)
        {
            writer.WriteStartElement(null, "CshInLieuOfShrPric", xmlNamespace );
            CashInLieuOfSharePriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IndicativeOrMarketPrice is IndicativeOrMarketPrice2Choice_ IndicativeOrMarketPriceValue)
        {
            writer.WriteStartElement(null, "IndctvOrMktPric", xmlNamespace );
            IndicativeOrMarketPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionPrice9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
