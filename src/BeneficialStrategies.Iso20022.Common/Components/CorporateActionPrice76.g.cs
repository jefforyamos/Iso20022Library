﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPrice76.  ISO2002 ID# _OovFnRuyEeyhRdHRjakS2w.
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
public partial record CorporateActionPrice76
     : IIsoXmlSerilizable<CorporateActionPrice76>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the price is an indicative price or a market price.
    /// </summary>
    public IndicativeOrMarketPrice8Choice_? IndicativeOrMarketPrice { get; init; } 
    /// <summary>
    /// Initial issue price of a financial instrument.
    /// </summary>
    public PriceFormat50Choice_? IssuePrice { get; init; } 
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    public PriceFormat66Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount, for example, reinvestment price.
    /// </summary>
    public PriceFormat50Choice_? GenericCashPricePaidPerProduct { get; init; } 
    
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
        if (IndicativeOrMarketPrice is IndicativeOrMarketPrice8Choice_ IndicativeOrMarketPriceValue)
        {
            writer.WriteStartElement(null, "IndctvOrMktPric", xmlNamespace );
            IndicativeOrMarketPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IssuePrice is PriceFormat50Choice_ IssuePriceValue)
        {
            writer.WriteStartElement(null, "IssePric", xmlNamespace );
            IssuePriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (GenericCashPriceReceivedPerProduct is PriceFormat66Choice_ GenericCashPriceReceivedPerProductValue)
        {
            writer.WriteStartElement(null, "GncCshPricRcvdPerPdct", xmlNamespace );
            GenericCashPriceReceivedPerProductValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (GenericCashPricePaidPerProduct is PriceFormat50Choice_ GenericCashPricePaidPerProductValue)
        {
            writer.WriteStartElement(null, "GncCshPricPdPerPdct", xmlNamespace );
            GenericCashPricePaidPerProductValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionPrice76 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
