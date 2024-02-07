﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashOption11.  ISO2002 ID# _6EAzMeGhEd-1Ktb5rVaajw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash option.
/// </summary>
public partial record CashOption11
     : IIsoXmlSerilizable<CashOption11>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the cash payment occurs or will occur in advance of receipt of proceeds from the issuer and based on a contractual agreement established with the account servicer or upon receipt of proceeds from the issuer.
    /// </summary>
    public Payment1Code? ContractualPaymentIndicator { get; init; } 
    /// <summary>
    /// Specifies information regarding outturn resources that cannot be processed by the Central Securities Depository (CSD). Special delivery instruction is required from the account owner for the corporate action outcome to be credited.
    /// </summary>
    public NonEligibleProceedsIndicator1Choice_? NonEligibleProceedsIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    public GenericIdentification20? IncomeType { get; init; } 
    /// <summary>
    /// Identification of the account in which cash is maintained.
    /// </summary>
    public CashAccountIdentification5Choice_? CashAccountIdentification { get; init; } 
    /// <summary>
    /// Provides information about the amounts related to a cash movement.
    /// </summary>
    public CorporateActionAmounts9? AmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the dates related to a cash movement.
    /// </summary>
    public required CorporateActionDate17 DateDetails { get; init; } 
    /// <summary>
    /// Exchange rate between the amount and the resulting amount.
    /// </summary>
    public ForeignExchangeTerms13? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Provides information about the corporate action option.
    /// </summary>
    public RateDetails3? RateAndAmountDetails { get; init; } 
    /// <summary>
    /// Provides information about the prices related to a corporate action option.
    /// </summary>
    public PriceDetails3? PriceDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "CdtDbtInd", xmlNamespace );
        writer.WriteValue(CreditDebitIndicator.ToString()); // Enum value
        writer.WriteEndElement();
        if (ContractualPaymentIndicator is Payment1Code ContractualPaymentIndicatorValue)
        {
            writer.WriteStartElement(null, "CtrctlPmtInd", xmlNamespace );
            writer.WriteValue(ContractualPaymentIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (NonEligibleProceedsIndicator is NonEligibleProceedsIndicator1Choice_ NonEligibleProceedsIndicatorValue)
        {
            writer.WriteStartElement(null, "NonElgblPrcdsInd", xmlNamespace );
            NonEligibleProceedsIndicatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IncomeType is GenericIdentification20 IncomeTypeValue)
        {
            writer.WriteStartElement(null, "IncmTp", xmlNamespace );
            IncomeTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashAccountIdentification is CashAccountIdentification5Choice_ CashAccountIdentificationValue)
        {
            writer.WriteStartElement(null, "CshAcctId", xmlNamespace );
            CashAccountIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AmountDetails is CorporateActionAmounts9 AmountDetailsValue)
        {
            writer.WriteStartElement(null, "AmtDtls", xmlNamespace );
            AmountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DtDtls", xmlNamespace );
        DateDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ForeignExchangeDetails is ForeignExchangeTerms13 ForeignExchangeDetailsValue)
        {
            writer.WriteStartElement(null, "FXDtls", xmlNamespace );
            ForeignExchangeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RateAndAmountDetails is RateDetails3 RateAndAmountDetailsValue)
        {
            writer.WriteStartElement(null, "RateAndAmtDtls", xmlNamespace );
            RateAndAmountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PriceDetails is PriceDetails3 PriceDetailsValue)
        {
            writer.WriteStartElement(null, "PricDtls", xmlNamespace );
            PriceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CashOption11 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
