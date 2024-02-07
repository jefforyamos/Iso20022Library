﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption179.  ISO2002 ID# _Dk8rIe2-Eeqc-LCjwLsUVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
public partial record CorporateActionOption179
     : IIsoXmlSerilizable<CorporateActionOption179>
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required CorporateActionOption33Choice_ OptionType { get; init; } 
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    public OptionFeaturesFormat18Choice_? OptionFeatures { get; init; } 
    /// <summary>
    /// Specifies how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
    /// </summary>
    public FractionDispositionType27Choice_? FractionDisposition { get; init; } 
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    /// <summary>
    /// Provides information about the dates related to a corporate action option.
    /// </summary>
    public CorporateActionDate79? DateDetails { get; init; } 
    /// <summary>
    /// Provides information about the periods related to a corporate action option.
    /// </summary>
    public CorporateActionPeriod13? PeriodDetails { get; init; } 
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    public CorporateActionRate107? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    public CorporateActionPrice61? PriceDetails { get; init; } 
    /// <summary>
    /// Place where the trade was executed.
    /// </summary>
    public MarketIdentification84? PlaceOfTrade { get; init; } 
    /// <summary>
    /// Provides information about the securities movement linked to the corporate action option.
    /// </summary>
    public SecuritiesOption70? SecuritiesMovementDetails { get; init; } 
    /// <summary>
    /// Provides information about the cash movement related to a corporate action option.
    /// </summary>
    public CashOption70? CashMovementDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "OptnNb", xmlNamespace );
        OptionNumber.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OptnTp", xmlNamespace );
        OptionType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OptionFeatures is OptionFeaturesFormat18Choice_ OptionFeaturesValue)
        {
            writer.WriteStartElement(null, "OptnFeatrs", xmlNamespace );
            OptionFeaturesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FractionDisposition is FractionDispositionType27Choice_ FractionDispositionValue)
        {
            writer.WriteStartElement(null, "FrctnDspstn", xmlNamespace );
            FractionDispositionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CurrencyOption is ActiveCurrencyCode CurrencyOptionValue)
        {
            writer.WriteStartElement(null, "CcyOptn", xmlNamespace );
            writer.WriteValue(CurrencyOptionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DateDetails is CorporateActionDate79 DateDetailsValue)
        {
            writer.WriteStartElement(null, "DtDtls", xmlNamespace );
            DateDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PeriodDetails is CorporateActionPeriod13 PeriodDetailsValue)
        {
            writer.WriteStartElement(null, "PrdDtls", xmlNamespace );
            PeriodDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RateAndAmountDetails is CorporateActionRate107 RateAndAmountDetailsValue)
        {
            writer.WriteStartElement(null, "RateAndAmtDtls", xmlNamespace );
            RateAndAmountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PriceDetails is CorporateActionPrice61 PriceDetailsValue)
        {
            writer.WriteStartElement(null, "PricDtls", xmlNamespace );
            PriceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PlaceOfTrade is MarketIdentification84 PlaceOfTradeValue)
        {
            writer.WriteStartElement(null, "PlcOfTrad", xmlNamespace );
            PlaceOfTradeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesMovementDetails is SecuritiesOption70 SecuritiesMovementDetailsValue)
        {
            writer.WriteStartElement(null, "SctiesMvmntDtls", xmlNamespace );
            SecuritiesMovementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashMovementDetails is CashOption70 CashMovementDetailsValue)
        {
            writer.WriteStartElement(null, "CshMvmntDtls", xmlNamespace );
            CashMovementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionOption179 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
