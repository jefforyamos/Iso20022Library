﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoanData140.  ISO2002 ID# _pjuw0czsEeux2uvSBFU54Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the loan data details in case of a buy sell back transaction.
/// </summary>
public partial record LoanData140
     : IIsoXmlSerilizable<LoanData140>
{
    #nullable enable
    
    /// <summary>
    /// Unique trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    public required IsoISODate EventDate { get; init; } 
    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    public IsoISODateTime? ExecutionDateTime { get; init; } 
    /// <summary>
    /// Indicates whether clearing of contract has taken place.
    /// </summary>
    public Cleared16Choice_? ClearingStatus { get; init; } 
    /// <summary>
    /// Identification of the trading venue where the transaction was executed.
    /// </summary>
    public IsoMICIdentifier? TradingVenue { get; init; } 
    /// <summary>
    /// Reference to master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    public MasterAgreement7? MasterAgreement { get; init; } 
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
    /// </summary>
    public IsoISODate? ValueDate { get; init; } 
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the closing leg (forward leg) of the transaction.
    /// </summary>
    public IsoISODate? MaturityDate { get; init; } 
    /// <summary>
    /// Indication whether the transaction is subject to a general collateral arrangement.
    /// </summary>
    public SpecialCollateral1Code? GeneralCollateral { get; init; } 
    /// <summary>
    /// Amount of money to be settled as of the start date and maturity date of the transaction.
    /// </summary>
    public PrincipalAmount3? PrincipalAmount { get; init; } 
    /// <summary>
    /// Price of unit of collateral component, including accrued interest for interest-bearing securities.
    /// </summary>
    public SecuritiesTransactionPrice19Choice_? UnitPrice { get; init; } 
    /// <summary>
    /// Termination date in the case of a full early termination of the Securities Financing Transaction (SFT).
    /// </summary>
    public IsoISODate? TerminationDate { get; init; } 
    
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
        if (UniqueTradeIdentifier is IsoMax52Text UniqueTradeIdentifierValue)
        {
            writer.WriteStartElement(null, "UnqTradIdr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax52Text(UniqueTradeIdentifierValue)); // data type Max52Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "EvtDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(EventDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (ExecutionDateTime is IsoISODateTime ExecutionDateTimeValue)
        {
            writer.WriteStartElement(null, "ExctnDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(ExecutionDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (ClearingStatus is Cleared16Choice_ ClearingStatusValue)
        {
            writer.WriteStartElement(null, "ClrSts", xmlNamespace );
            ClearingStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TradingVenue is IsoMICIdentifier TradingVenueValue)
        {
            writer.WriteStartElement(null, "TradgVn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMICIdentifier(TradingVenueValue)); // data type MICIdentifier System.String
            writer.WriteEndElement();
        }
        if (MasterAgreement is MasterAgreement7 MasterAgreementValue)
        {
            writer.WriteStartElement(null, "MstrAgrmt", xmlNamespace );
            MasterAgreementValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ValueDate is IsoISODate ValueDateValue)
        {
            writer.WriteStartElement(null, "ValDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ValueDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (MaturityDate is IsoISODate MaturityDateValue)
        {
            writer.WriteStartElement(null, "MtrtyDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(MaturityDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (GeneralCollateral is SpecialCollateral1Code GeneralCollateralValue)
        {
            writer.WriteStartElement(null, "GnlColl", xmlNamespace );
            writer.WriteValue(GeneralCollateralValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PrincipalAmount is PrincipalAmount3 PrincipalAmountValue)
        {
            writer.WriteStartElement(null, "PrncplAmt", xmlNamespace );
            PrincipalAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnitPrice is SecuritiesTransactionPrice19Choice_ UnitPriceValue)
        {
            writer.WriteStartElement(null, "UnitPric", xmlNamespace );
            UnitPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TerminationDate is IsoISODate TerminationDateValue)
        {
            writer.WriteStartElement(null, "TermntnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(TerminationDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static LoanData140 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
