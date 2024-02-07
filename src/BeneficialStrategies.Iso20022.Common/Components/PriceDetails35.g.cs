﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PriceDetails35.  ISO2002 ID# _YXpTUV99Ee262vCSVgjImg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the prices related to a corporate action option.
/// </summary>
public partial record PriceDetails35
     : IIsoXmlSerilizable<PriceDetails35>
{
    #nullable enable
    
    /// <summary>
    /// Generic cash price paid per product by the underlying security holder either as a percentage or an amount or a number of points above an index, for example, reinvestment price, strike price and exercise price.
    /// </summary>
    public PriceFormat59Choice_? GenericCashPricePaidPerProduct { get; init; } 
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    public PriceFormat70Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    public PriceFormat57Choice_? CashInLieuOfSharePrice { get; init; } 
    
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
        if (GenericCashPricePaidPerProduct is PriceFormat59Choice_ GenericCashPricePaidPerProductValue)
        {
            writer.WriteStartElement(null, "GncCshPricPdPerPdct", xmlNamespace );
            GenericCashPricePaidPerProductValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (GenericCashPriceReceivedPerProduct is PriceFormat70Choice_ GenericCashPriceReceivedPerProductValue)
        {
            writer.WriteStartElement(null, "GncCshPricRcvdPerPdct", xmlNamespace );
            GenericCashPriceReceivedPerProductValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashInLieuOfSharePrice is PriceFormat57Choice_ CashInLieuOfSharePriceValue)
        {
            writer.WriteStartElement(null, "CshInLieuOfShrPric", xmlNamespace );
            CashInLieuOfSharePriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PriceDetails35 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
