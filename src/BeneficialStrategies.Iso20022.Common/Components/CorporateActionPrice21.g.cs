﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPrice21.  ISO2002 ID# _4rfMQfPEEd-SiYFtSzfh2Q.
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
public partial record CorporateActionPrice21
     : IIsoXmlSerilizable<CorporateActionPrice21>
{
    #nullable enable
    
    /// <summary>
    /// Generic cash price received per product by the underlying security holder either as a percentage or an amount, for example, redemption price.
    /// </summary>
    public PriceFormat7Choice_? GenericCashPriceReceivedPerProduct { get; init; } 
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    public PriceFormat5Choice_? CashInLieuOfSharePrice { get; init; } 
    /// <summary>
    /// Amount of money required per over-subscribed equity as defined by the issuer.
    /// </summary>
    public PriceFormat5Choice_? OverSubscriptionDepositPrice { get; init; } 
    
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
        if (GenericCashPriceReceivedPerProduct is PriceFormat7Choice_ GenericCashPriceReceivedPerProductValue)
        {
            writer.WriteStartElement(null, "GncCshPricRcvdPerPdct", xmlNamespace );
            GenericCashPriceReceivedPerProductValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashInLieuOfSharePrice is PriceFormat5Choice_ CashInLieuOfSharePriceValue)
        {
            writer.WriteStartElement(null, "CshInLieuOfShrPric", xmlNamespace );
            CashInLieuOfSharePriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OverSubscriptionDepositPrice is PriceFormat5Choice_ OverSubscriptionDepositPriceValue)
        {
            writer.WriteStartElement(null, "OverSbcptDpstPric", xmlNamespace );
            OverSubscriptionDepositPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionPrice21 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
