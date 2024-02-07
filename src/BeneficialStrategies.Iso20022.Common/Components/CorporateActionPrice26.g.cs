﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPrice26.  ISO2002 ID# _M6nGkfo1EeCqjOT-vUu2sQ.
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
public partial record CorporateActionPrice26
     : IIsoXmlSerilizable<CorporateActionPrice26>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    public IndicativeOrMarketPrice5Choice_? IndicativeOrMarketPrice { get; init; } 
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    public PriceFormat19Choice_? CashInLieuOfSharePrice { get; init; } 
    /// <summary>
    /// Cash value of resulting securities proceeds for tax calculation and/or reporting.
    /// </summary>
    public PriceFormat29Choice_? CashValueForTax { get; init; } 
    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount, for example, reinvestment price.
    /// </summary>
    public PriceFormat23Choice_? GenericCashPricePaidPerProduct { get; init; } 
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    public PriceFormat20Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    
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
        if (IndicativeOrMarketPrice is IndicativeOrMarketPrice5Choice_ IndicativeOrMarketPriceValue)
        {
            writer.WriteStartElement(null, "IndctvOrMktPric", xmlNamespace );
            IndicativeOrMarketPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashInLieuOfSharePrice is PriceFormat19Choice_ CashInLieuOfSharePriceValue)
        {
            writer.WriteStartElement(null, "CshInLieuOfShrPric", xmlNamespace );
            CashInLieuOfSharePriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashValueForTax is PriceFormat29Choice_ CashValueForTaxValue)
        {
            writer.WriteStartElement(null, "CshValForTax", xmlNamespace );
            CashValueForTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (GenericCashPricePaidPerProduct is PriceFormat23Choice_ GenericCashPricePaidPerProductValue)
        {
            writer.WriteStartElement(null, "GncCshPricPdPerPdct", xmlNamespace );
            GenericCashPricePaidPerProductValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (GenericCashPriceReceivedPerProduct is PriceFormat20Choice_ GenericCashPriceReceivedPerProductValue)
        {
            writer.WriteStartElement(null, "GncCshPricRcvdPerPdct", xmlNamespace );
            GenericCashPriceReceivedPerProductValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionPrice26 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
