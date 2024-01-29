﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesStatementQuery002V07.  ISO2002 ID# _-JFicyAdEeuyDZ-ukt4YRg.
//
namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// Scope
/// An account owner sends a SecuritiesStatementQuery to an account servicer to request any existing securities statement.
/// The account owner/servicer relationship may be:
/// - a global custodian which has an account with a local custodian, or
/// - an investment management institution which manage a fund account opened at a custodian, or
/// - a broker which has an account with a custodian, or
/// - a central securities depository participant which has an account with a central securities depository, or
/// - a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or
/// - a central counterparty or a stock exchange or a trade matching utility which need to instruct to a central securities depository or another settlement market infrastructure.
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An account owner sends a SecuritiesStatementQuery to an account servicer to request any existing securities statement.|The account owner/servicer relationship may be:|- a global custodian which has an account with a local custodian, or|- an investment management institution which manage a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository participant which has an account with a central securities depository, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or|- a central counterparty or a stock exchange or a trade matching utility which need to instruct to a central securities depository or another settlement market infrastructure.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
public partial record SecuritiesStatementQuery002V07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesStmtQry";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Description of the statement requested.
    /// </summary>
    [IsoId("_-JFidSAdEeuyDZ-ukt4YRg")]
    [Description(@"Description of the statement requested.")]
    [DataMember(Name="StmtReqd")]
    [XmlElement(ElementName="StmtReqd")]
    [Required]
    public required SomeStatementRequestedRecord StatementRequested { get; init; }
    
    /// <summary>
    /// General information related to the report.
    /// </summary>
    [IsoId("_-JFidyAdEeuyDZ-ukt4YRg")]
    [Description(@"General information related to the report.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    public SomeStatementGeneralDetailsRecord? StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_-JFieSAdEeuyDZ-ukt4YRg")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public SomeAccountOwnerRecord? AccountOwner { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_-JFieyAdEeuyDZ-ukt4YRg")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    [Required]
    public required SomeSafekeepingAccountRecord SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Additional specific query criteria.
    /// </summary>
    [IsoId("_-JFifSAdEeuyDZ-ukt4YRg")]
    [Description(@"Additional specific query criteria.")]
    [DataMember(Name="AddtlQryParams")]
    [XmlElement(ElementName="AddtlQryParams")]
    public SomeAdditionalQueryParametersRecord? AdditionalQueryParameters { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_-JFifyAdEeuyDZ-ukt4YRg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SomeSupplementaryDataRecord? SupplementaryData { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesStatementQuery002V07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesStatementQuery002V07Document ToDocument()
    {
        return new SecuritiesStatementQuery002V07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesStatementQuery002V07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesStatementQuery002V07Document : IOuterDocument<SecuritiesStatementQuery002V07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.021.002.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesStatementQuery002V07"/> is required.
    /// </summary>
    public required SecuritiesStatementQuery002V07 Message { get; init; }
}