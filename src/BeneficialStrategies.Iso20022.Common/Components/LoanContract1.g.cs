﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoanContract1.  ISO2002 ID# _uCfA8NLJEeSdq5yU2aaSNw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contract by which an amount of money in exchange for future repayment of the principal amount along with interest or other finance charges.
/// </summary>
public partial record LoanContract1
     : IIsoXmlSerilizable<LoanContract1>
{
    #nullable enable
    
    /// <summary>
    /// Contract document referenced from this loan agreement.
    /// </summary>
    public required DocumentIdentification22 ContractDocumentIdentification { get; init; } 
    /// <summary>
    /// Party that is specified as the buyer for this loan agreement.
    /// </summary>
    public TradeParty2? Buyer { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _PSp2I9NDEeSDLevdaFPXHw
    /// <summary>
    /// Party that is specified as the seller for this loan agreement.
    /// </summary>
    public TradeParty2? Seller { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _PSp2JNNDEeSDLevdaFPXHw
    /// <summary>
    /// Loan amount as defined in the contract.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Planned final repayment date at the time of issuance.
    /// </summary>
    public required IsoISODate MaturityDate { get; init; } 
    /// <summary>
    /// Indicates whether the contract duration is extended or not.
    /// </summary>
    public required IsoTrueFalseIndicator ProlongationFlag { get; init; } 
    /// <summary>
    /// Start date of the loan contract.
    /// </summary>
    public required IsoISODate StartDate { get; init; } 
    /// <summary>
    /// Currency in which the loan is being settled.
    /// </summary>
    public required ActiveCurrencyCode SettlementCurrency { get; init; } 
    /// <summary>
    /// When the amount is credited outside of the country, special conditions are applicable.
    /// </summary>
    public SpecialCondition1? SpecialConditions { get; init; } 
    /// <summary>
    /// Loan duration in a coded form.
    /// </summary>
    public required IsoExact1NumericText DurationCode { get; init; } 
    /// <summary>
    /// Interest rate for the loan.
    /// </summary>
    public required InterestRate2Choice_ InterestRate { get; init; } 
    /// <summary>
    /// One part or division of the loan, used to define the repayment.
    /// </summary>
    public LoanContractTranche1? Tranche { get; init; } 
    /// <summary>
    /// Schedule of the payments defined for the loan contract.
    /// </summary>
    public PaymentSchedule1Choice_? PaymentSchedule { get; init; } 
    /// <summary>
    /// Schedule of the interest payments defined for the loan contract.
    /// </summary>
    public required InterestPaymentSchedule1Choice_ InterestSchedule { get; init; } 
    /// <summary>
    /// Loan is an intra company loan.
    /// </summary>
    public required IsoTrueFalseIndicator IntraCompanyLoan { get; init; } 
    /// <summary>
    /// Details of the collateral for the loan.
    /// </summary>
    public ContractCollateral1? Collateral { get; init; } 
    /// <summary>
    /// Loan offered by a group of lenders (called a syndicate) who work together to provide funds for a single borrower.
    /// </summary>
    public SyndicatedLoan1? SyndicatedLoan { get; init; } 
    /// <summary>
    /// Documents provided as attachments to the loan contract.
    /// </summary>
    public DocumentGeneralInformation3? Attachment { get; init; } 
    
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
        writer.WriteStartElement(null, "CtrctDocId", xmlNamespace );
        ContractDocumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize Buyer, multiplicity Unknown
        // Not sure how to serialize Seller, multiplicity Unknown
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(Amount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "MtrtyDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(MaturityDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "PrlngtnFlg", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(ProlongationFlag)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "StartDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(StartDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SttlmCcy", xmlNamespace );
        writer.WriteValue(SettlementCurrency.ToString()); // Enum value
        writer.WriteEndElement();
        if (SpecialConditions is SpecialCondition1 SpecialConditionsValue)
        {
            writer.WriteStartElement(null, "SpclConds", xmlNamespace );
            SpecialConditionsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "DrtnCd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoExact1NumericText(DurationCode)); // data type Exact1NumericText System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IntrstRate", xmlNamespace );
        InterestRate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Tranche is LoanContractTranche1 TrancheValue)
        {
            writer.WriteStartElement(null, "Trch", xmlNamespace );
            TrancheValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PaymentSchedule is PaymentSchedule1Choice_ PaymentScheduleValue)
        {
            writer.WriteStartElement(null, "PmtSchdl", xmlNamespace );
            PaymentScheduleValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "IntrstSchdl", xmlNamespace );
        InterestSchedule.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IntraCpnyLn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(IntraCompanyLoan)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
        if (Collateral is ContractCollateral1 CollateralValue)
        {
            writer.WriteStartElement(null, "Coll", xmlNamespace );
            CollateralValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SyndicatedLoan is SyndicatedLoan1 SyndicatedLoanValue)
        {
            writer.WriteStartElement(null, "SndctdLn", xmlNamespace );
            SyndicatedLoanValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Attachment is DocumentGeneralInformation3 AttachmentValue)
        {
            writer.WriteStartElement(null, "Attchmnt", xmlNamespace );
            AttachmentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static LoanContract1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
