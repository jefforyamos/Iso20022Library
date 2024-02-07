﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPrice68.  ISO2002 ID# _n-nV0ZbSEee8S7xwGG7Veg.
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
public partial record CorporateActionPrice68
     : IIsoXmlSerilizable<CorporateActionPrice68>
{
    #nullable enable
    
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    public PriceFormat45Choice_? CashInLieuOfSharePrice { get; init; } 
    /// <summary>
    /// Amount of money required per over-subscribed equity as defined by the issuer.
    /// </summary>
    public PriceFormat45Choice_? OverSubscriptionDepositPrice { get; init; } 
    /// <summary>
    /// Maximum cash amount that may be instructed.
    /// </summary>
    public PriceFormat61Choice_? MaximumCashToInstruct { get; init; } 
    /// <summary>
    /// Minimum cash amount that may be instructed.
    /// </summary>
    public PriceFormat61Choice_? MinimumCashToInstruct { get; init; } 
    /// <summary>
    /// Minimum multiple of a cash amount that may be instructed.
    /// </summary>
    public PriceFormat61Choice_? MinimumMultipleCashToInstruct { get; init; } 
    
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
        if (CashInLieuOfSharePrice is PriceFormat45Choice_ CashInLieuOfSharePriceValue)
        {
            writer.WriteStartElement(null, "CshInLieuOfShrPric", xmlNamespace );
            CashInLieuOfSharePriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OverSubscriptionDepositPrice is PriceFormat45Choice_ OverSubscriptionDepositPriceValue)
        {
            writer.WriteStartElement(null, "OverSbcptDpstPric", xmlNamespace );
            OverSubscriptionDepositPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MaximumCashToInstruct is PriceFormat61Choice_ MaximumCashToInstructValue)
        {
            writer.WriteStartElement(null, "MaxCshToInst", xmlNamespace );
            MaximumCashToInstructValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MinimumCashToInstruct is PriceFormat61Choice_ MinimumCashToInstructValue)
        {
            writer.WriteStartElement(null, "MinCshToInst", xmlNamespace );
            MinimumCashToInstructValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MinimumMultipleCashToInstruct is PriceFormat61Choice_ MinimumMultipleCashToInstructValue)
        {
            writer.WriteStartElement(null, "MinMltplCshToInst", xmlNamespace );
            MinimumMultipleCashToInstructValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionPrice68 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
