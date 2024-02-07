﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoanData98.  ISO2002 ID# _4Eg3F__qEemm3skPVSMJQg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the loan data details in case of a securities lending transaction.
/// </summary>
public partial record LoanData98
     : IIsoXmlSerilizable<LoanData98>
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
    /// </summary>
    public required IsoTrueFalseIndicator DeliveryByValue { get; init; } 
    /// <summary>
    /// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
    /// </summary>
    public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; } 
    /// <summary>
    /// Indication whether the transaction is open term or, i.e. has no fixed maturity date, or fixed term with a contractually agreed maturity date.
    /// </summary>
    public ContractTerm3Choice_? Term { get; init; } 
    /// <summary>
    /// Indication of the type of assets subject of the transaction.
    /// </summary>
    public required SecurityCommodity8 AssetType { get; init; } 
    /// <summary>
    /// Interest rate (rate agreed to be paid by the lender for the reinvestment of the cash collateral minus lending fee) paid by the lender of the security or commodity to the borrower (positive rebate rate) or by the borrower to the lender (negative rebate rate) on the balance of the provided cash collateral.
    /// </summary>
    public required InterestRate20Choice_ RebateRate { get; init; } 
    /// <summary>
    /// Specifies loan value, that is the quantity or nominal amount multiplied by the price.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount LoanValue { get; init; } 
    /// <summary>
    /// Fee that the borrower of the security or commodity pays to the lender.
    /// </summary>
    public IsoPercentageRate? LendingFee { get; init; } 
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    public required IsoMax52Text UniqueTradeIdentifier { get; init; } 
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place. In the case of action types valuation update, collateral update, reuse update, margin update, the date for which the information contained in the report is provided.
    /// </summary>
    public required IsoISODate EventDate { get; init; } 
    /// <summary>
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    public required Cleared10Choice_ ClearingStatus { get; init; } 
    /// <summary>
    /// Venue of execution shall be identified by a unique code for this venue.
    /// </summary>
    public required IsoMICIdentifier TradingVenue { get; init; } 
    /// <summary>
    /// Reference to master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    public MasterAgreement6? MasterAgreement { get; init; } 
    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    public required IsoISODateTime ExecutionDateTime { get; init; } 
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term repurchase transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
    /// </summary>
    public required IsoISODate ValueDate { get; init; } 
    /// <summary>
    /// Termination date in the case of a full early termination of the reported transaction.
    /// </summary>
    public IsoISODate? TerminationDate { get; init; } 
    /// <summary>
    /// Indication whether the transaction is subject to a general collateral arrangement. -‘true’ shall be populated for general collateral. General collateral specifies a collateral arrangement for a repurchase transaction in which the security lender may choose the security to provide as collateral with the cash provider amongst a relatively wide range of securities meeting predefined criteria.
    /// -‘false’ shall be populated for specific collateral. Specific collateral specifies a collateral arrangement for a repurchase transaction in which the buyer requests a specific security or commodity (individual ISIN) to be provided by the seller.
    /// </summary>
    public SpecialCollateral1Code? GeneralCollateral { get; init; } 
    
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
        writer.WriteStartElement(null, "DlvryByVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(DeliveryByValue)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
        if (CollateralDeliveryMethod is CollateralDeliveryMethod1Code CollateralDeliveryMethodValue)
        {
            writer.WriteStartElement(null, "CollDlvryMtd", xmlNamespace );
            writer.WriteValue(CollateralDeliveryMethodValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Term is ContractTerm3Choice_ TermValue)
        {
            writer.WriteStartElement(null, "Term", xmlNamespace );
            TermValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AsstTp", xmlNamespace );
        AssetType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RbtRate", xmlNamespace );
        RebateRate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LnVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(LoanValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (LendingFee is IsoPercentageRate LendingFeeValue)
        {
            writer.WriteStartElement(null, "LndgFee", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(LendingFeeValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "UnqTradIdr", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax52Text(UniqueTradeIdentifier)); // data type Max52Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "EvtDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(EventDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ClrSts", xmlNamespace );
        ClearingStatus.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "TradgVn", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMICIdentifier(TradingVenue)); // data type MICIdentifier System.String
        writer.WriteEndElement();
        if (MasterAgreement is MasterAgreement6 MasterAgreementValue)
        {
            writer.WriteStartElement(null, "MstrAgrmt", xmlNamespace );
            MasterAgreementValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ExctnDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(ExecutionDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ValDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(ValueDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (TerminationDate is IsoISODate TerminationDateValue)
        {
            writer.WriteStartElement(null, "TermntnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(TerminationDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (GeneralCollateral is SpecialCollateral1Code GeneralCollateralValue)
        {
            writer.WriteStartElement(null, "GnlColl", xmlNamespace );
            writer.WriteValue(GeneralCollateralValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static LoanData98 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
