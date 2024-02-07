﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption180.  ISO2002 ID# _6HnzQe34Eeqc-LCjwLsUVg.
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
public partial record CorporateActionOption180
     : IIsoXmlSerilizable<CorporateActionOption180>
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required CorporateActionOption40Choice_ OptionType { get; init; } 
    /// <summary>
    /// Specifies the features that may apply to a corporate action option.
    /// </summary>
    public OptionFeaturesFormat25Choice_? OptionFeatures { get; init; } 
    /// <summary>
    /// Specifies how fractional amount/quantities are treated.
    /// </summary>
    public FractionDispositionType28Choice_? FractionDisposition { get; init; } 
    /// <summary>
    /// Type of changes affecting the security form.
    /// </summary>
    public CorporateActionChangeTypeFormat6Choice_? ChangeType { get; init; } 
    /// <summary>
    /// Indicates that the corporate action instruction is to be processed using the Available-for-Collateral pool.
    /// </summary>
    public IsoYesNoIndicator? EligibleForCollateralIndicator { get; init; } 
    /// <summary>
    /// Indicates whether there is a solicitation fee on the event. This fee is paid by the soliciting dealer.
    /// </summary>
    public IsoYesNoIndicator? SolicitationDealerFeeIndicator { get; init; } 
    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds.
    /// </summary>
    public ActiveCurrencyCode? CurrencyToBuy { get; init; } 
    /// <summary>
    /// Account servicer is instructed to sell the indicated currency in order to obtain the necessary currency to fund the transaction within this instruction message.
    /// </summary>
    public ActiveCurrencyCode? CurrencyToSell { get; init; } 
    /// <summary>
    /// Currency in which the cash disbursed from an interest or dividend payment is offered.
    /// </summary>
    public ActiveCurrencyCode? CurrencyOption { get; init; } 
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    public SecurityIdentification19? SecurityIdentification { get; init; } 
    /// <summary>
    /// Provides information about securities quantity linked to a corporate action option.
    /// </summary>
    public required SecuritiesQuantityOrAmount4Choice_ SecuritiesQuantityOrInstructedAmount { get; init; } 
    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed.
    /// </summary>
    public DateAndDateTime2Choice_? ExecutionRequestedDateTime { get; init; } 
    /// <summary>
    /// Provides information about rates and amounts related to a corporate action option.
    /// </summary>
    public CorporateActionRate71? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    public CorporateActionPrice60? PriceDetails { get; init; } 
    /// <summary>
    /// Reference number assigned to identify an investor or a shareholder with the issuer or the registration provider (for instance allocation code).
    /// </summary>
    public IsoMax25Text? ShareholderNumber { get; init; } 
    /// <summary>
    /// Provides additional information.
    /// </summary>
    public CorporateActionNarrative32? AdditionalInformation { get; init; } 
    
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
        if (OptionFeatures is OptionFeaturesFormat25Choice_ OptionFeaturesValue)
        {
            writer.WriteStartElement(null, "OptnFeatrs", xmlNamespace );
            OptionFeaturesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FractionDisposition is FractionDispositionType28Choice_ FractionDispositionValue)
        {
            writer.WriteStartElement(null, "FrctnDspstn", xmlNamespace );
            FractionDispositionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ChangeType is CorporateActionChangeTypeFormat6Choice_ ChangeTypeValue)
        {
            writer.WriteStartElement(null, "ChngTp", xmlNamespace );
            ChangeTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EligibleForCollateralIndicator is IsoYesNoIndicator EligibleForCollateralIndicatorValue)
        {
            writer.WriteStartElement(null, "ElgblForCollInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(EligibleForCollateralIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (SolicitationDealerFeeIndicator is IsoYesNoIndicator SolicitationDealerFeeIndicatorValue)
        {
            writer.WriteStartElement(null, "SlctnDealrFeeInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(SolicitationDealerFeeIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (CurrencyToBuy is ActiveCurrencyCode CurrencyToBuyValue)
        {
            writer.WriteStartElement(null, "CcyToBuy", xmlNamespace );
            writer.WriteValue(CurrencyToBuyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CurrencyToSell is ActiveCurrencyCode CurrencyToSellValue)
        {
            writer.WriteStartElement(null, "CcyToSell", xmlNamespace );
            writer.WriteValue(CurrencyToSellValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (CurrencyOption is ActiveCurrencyCode CurrencyOptionValue)
        {
            writer.WriteStartElement(null, "CcyOptn", xmlNamespace );
            writer.WriteValue(CurrencyOptionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SecurityIdentification is SecurityIdentification19 SecurityIdentificationValue)
        {
            writer.WriteStartElement(null, "SctyId", xmlNamespace );
            SecurityIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SctiesQtyOrInstdAmt", xmlNamespace );
        SecuritiesQuantityOrInstructedAmount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ExecutionRequestedDateTime is DateAndDateTime2Choice_ ExecutionRequestedDateTimeValue)
        {
            writer.WriteStartElement(null, "ExctnReqdDtTm", xmlNamespace );
            ExecutionRequestedDateTimeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RateAndAmountDetails is CorporateActionRate71 RateAndAmountDetailsValue)
        {
            writer.WriteStartElement(null, "RateAndAmtDtls", xmlNamespace );
            RateAndAmountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PriceDetails is CorporateActionPrice60 PriceDetailsValue)
        {
            writer.WriteStartElement(null, "PricDtls", xmlNamespace );
            PriceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ShareholderNumber is IsoMax25Text ShareholderNumberValue)
        {
            writer.WriteStartElement(null, "ShrhldrNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax25Text(ShareholderNumberValue)); // data type Max25Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalInformation is CorporateActionNarrative32 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionOption180 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
