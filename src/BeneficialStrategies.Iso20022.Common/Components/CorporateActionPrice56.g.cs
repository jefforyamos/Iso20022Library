﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPrice56.  ISO2002 ID# _JpNVoUEFEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices related to a corporate action option.
/// </summary>
public partial record CorporateActionPrice56
     : IIsoXmlSerilizable<CorporateActionPrice56>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    public IndicativeOrMarketPrice7Choice_? IndicativeOrMarketPrice { get; init; } 
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    public PriceFormat45Choice_? CashInLieuOfSharePrice { get; init; } 
    /// <summary>
    /// Cash value of resulting securities proceeds for tax calculation and/or reporting.
    /// </summary>
    public PriceFormat46Choice_? CashValueForTax { get; init; } 
    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount or a number of points above an index, for example, reinvestment price, strike price and exercise price.
    /// </summary>
    public PriceFormat44Choice_? GenericCashPricePaidPerProduct { get; init; } 
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    public PriceFormat47Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    
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
        if (IndicativeOrMarketPrice is IndicativeOrMarketPrice7Choice_ IndicativeOrMarketPriceValue)
        {
            writer.WriteStartElement(null, "IndctvOrMktPric", xmlNamespace );
            IndicativeOrMarketPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashInLieuOfSharePrice is PriceFormat45Choice_ CashInLieuOfSharePriceValue)
        {
            writer.WriteStartElement(null, "CshInLieuOfShrPric", xmlNamespace );
            CashInLieuOfSharePriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashValueForTax is PriceFormat46Choice_ CashValueForTaxValue)
        {
            writer.WriteStartElement(null, "CshValForTax", xmlNamespace );
            CashValueForTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (GenericCashPricePaidPerProduct is PriceFormat44Choice_ GenericCashPricePaidPerProductValue)
        {
            writer.WriteStartElement(null, "GncCshPricPdPerPdct", xmlNamespace );
            GenericCashPricePaidPerProductValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (GenericCashPriceReceivedPerProduct is PriceFormat47Choice_ GenericCashPriceReceivedPerProductValue)
        {
            writer.WriteStartElement(null, "GncCshPricRcvdPerPdct", xmlNamespace );
            GenericCashPriceReceivedPerProductValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionPrice56 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
