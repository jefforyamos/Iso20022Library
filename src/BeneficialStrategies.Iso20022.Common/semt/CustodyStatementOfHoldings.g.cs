﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CustodyStatementOfHoldings.  ISO2002 ID# _MWx4gNFSEd-BzquC8wXy7w_650597621.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.semt;


/// <summary>
/// Scope
/// The CustodyStatementOfHoldings message is sent by an account servicer to the account owner or the account owner's designated agent. The account servicer may be a local agent acting on behalf of its global custodian customer, a custodian acting on behalf of an investment management institution or a broker/dealer, a fund administrator or fund intermediary, trustee or registrar, etc.
/// This message reports, at a specified moment in time, the quantity and identification of financial instruments that an account servicer holds for the account owner.
/// This message is used to reconcile the books of the account owner and the account servicer for the specified account or sub-account.
/// This message can also report availability and/or the location of security holdings to facilitate trading and minimise settlement issues. The reporting is per financial instrument, ie, when a financial instrument is held at multiple places of safekeeping, the total holding for all locations can be provided.
/// Usage
/// The CustodyStatementOfHoldings message can be sent:
/// - At a frequency agreed bi-laterally between the Sender and the Receiver
/// - As a response to a request for statement sent by the account owner.
/// This message can reflect all outstanding holding information or may only contain changes since the previously sent statement.
/// The CustodyStatementOfHoldings message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, this message can be used to either specify holdings at
/// - the main account level, or
/// - the sub-account level.
/// This message can be also be used to report where the securities are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated.
/// This message must not be used to report audited positions. Audited positions are reported using the AccountingStatementOfHoldings message.
/// Since a SWIFT message as sent is restricted to the maximum input message length, several messages may be needed to accommodate all the information.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CustodyStatementOfHoldings message is sent by an account servicer to the account owner or the account owner's designated agent. The account servicer may be a local agent acting on behalf of its global custodian customer, a custodian acting on behalf of an investment management institution or a broker/dealer, a fund administrator or fund intermediary, trustee or registrar, etc.|This message reports, at a specified moment in time, the quantity and identification of financial instruments that an account servicer holds for the account owner.|This message is used to reconcile the books of the account owner and the account servicer for the specified account or sub-account.|This message can also report availability and/or the location of security holdings to facilitate trading and minimise settlement issues. The reporting is per financial instrument, ie, when a financial instrument is held at multiple places of safekeeping, the total holding for all locations can be provided.|Usage|The CustodyStatementOfHoldings message can be sent:|- At a frequency agreed bi-laterally between the Sender and the Receiver|- As a response to a request for statement sent by the account owner.|This message can reflect all outstanding holding information or may only contain changes since the previously sent statement.|The CustodyStatementOfHoldings message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, this message can be used to either specify holdings at|- the main account level, or|- the sub-account level.|This message can be also be used to report where the securities are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated.|This message must not be used to report audited positions. Audited positions are reported using the AccountingStatementOfHoldings message.|Since a SWIFT message as sent is restricted to the maximum input message length, several messages may be needed to accommodate all the information.")]
public partial record CustodyStatementOfHoldings : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "semt.002.001.01";
    
    #nullable enable
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_MW7pgNFSEd-BzquC8wXy7w_1818905401")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_MW7pgdFSEd-BzquC8wXy7w_1810591867")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_MW7pgtFSEd-BzquC8wXy7w_-1884866352")]
    [Description(@"Pagination of the message.")]
    [DataMember(Name="MsgPgntn")]
    [XmlElement(ElementName="MsgPgntn")]
    [Required]
    public required Pagination MessagePagination { get; init; }
    
    /// <summary>
    /// General information related to the custody statement of holdings.
    /// </summary>
    [IsoId("_MW7pg9FSEd-BzquC8wXy7w_500773271")]
    [Description(@"General information related to the custody statement of holdings.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    [Required]
    public required Statement3 StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// The safekeeping or investment account.
    /// </summary>
    [IsoId("_MW7phNFSEd-BzquC8wXy7w_-1316963479")]
    [Description(@"The safekeeping or investment account.")]
    [DataMember(Name="AcctDtls")]
    [XmlElement(ElementName="AcctDtls")]
    [Required]
    public required SafekeepingAccount1 AccountDetails { get; init; }
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_MW7phdFSEd-BzquC8wXy7w_-2003208951")]
    [Description(@"Net position of a segregated holding, in a single security, within the overall position held in a securities account.")]
    [DataMember(Name="BalForAcct")]
    [XmlElement(ElementName="BalForAcct")]
    public AggregateBalanceInformation1? BalanceForAccount { get; init; }
    
    /// <summary>
    /// The sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_MW7phtFSEd-BzquC8wXy7w_1776832052")]
    [Description(@"The sub-account of the safekeeping or investment account.")]
    [DataMember(Name="SubAcctDtls")]
    [XmlElement(ElementName="SubAcctDtls")]
    public SubAccountIdentification1? SubAccountDetails { get; init; }
    
    /// <summary>
    /// Value of total holdings reported.
    /// </summary>
    [IsoId("_MW7ph9FSEd-BzquC8wXy7w_1111399368")]
    [Description(@"Value of total holdings reported.")]
    [DataMember(Name="TtlVals")]
    [XmlElement(ElementName="TtlVals")]
    public TotalValueInPageAndStatement? TotalValues { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_MXEzcNFSEd-BzquC8wXy7w_-143061138")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CustodyStatementOfHoldingsDocument"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CustodyStatementOfHoldingsDocument ToDocument()
    {
        return new CustodyStatementOfHoldingsDocument { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CustodyStatementOfHoldings"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CustodyStatementOfHoldingsDocument : IOuterDocument<CustodyStatementOfHoldings>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.002.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CustodyStatementOfHoldings"/> is required.
    /// </summary>
    public required CustodyStatementOfHoldings Message { get; init; }
}
