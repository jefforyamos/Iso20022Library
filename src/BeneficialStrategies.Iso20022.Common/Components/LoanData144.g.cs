﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoanData144.  ISO2002 ID# _M55MIcz4EeufhKfUxzsnrQ.
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
public partial record LoanData144
     : IIsoXmlSerilizable<LoanData144>
{
    #nullable enable
    
    /// <summary>
    /// Indication of the cash values to be settled as of the start and maturity date of the transaction.
    /// </summary>
    public PrincipalAmount3? PrincipalAmount { get; init; } 
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the closing leg (forward leg) of the secured financing transaction. This information shall not be reported for open term agreements.
    /// </summary>
    public required IsoISODate MaturityDate { get; init; } 
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
    public required Cleared16Choice_ ClearingStatus { get; init; } 
    /// <summary>
    /// Venue of execution shall be identified by a unique code for this venue.
    /// </summary>
    public required IsoMICIdentifier TradingVenue { get; init; } 
    /// <summary>
    /// Reference to master agreement under which the counterparties concluded a documented transaction.
    /// </summary>
    public MasterAgreement7? MasterAgreement { get; init; } 
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
    /// <summary>
    /// Price of unit of collateral component, including accrued interest for interest-bearing securities.
    /// </summary>
    public SecuritiesTransactionPrice19Choice_? UnitPrice { get; init; } 
    
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
        if (PrincipalAmount is PrincipalAmount3 PrincipalAmountValue)
        {
            writer.WriteStartElement(null, "PrncplAmt", xmlNamespace );
            PrincipalAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "MtrtyDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(MaturityDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
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
        if (MasterAgreement is MasterAgreement7 MasterAgreementValue)
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
        if (UnitPrice is SecuritiesTransactionPrice19Choice_ UnitPriceValue)
        {
            writer.WriteStartElement(null, "UnitPric", xmlNamespace );
            UnitPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static LoanData144 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
