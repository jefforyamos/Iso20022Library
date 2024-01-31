﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesBalanceAccountingReport002V11.  ISO2002 ID# _ch560zi8Eeydid5dcNPKvg.
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
/// An account servicer sends a SecuritiesBalanceAccountingReport to an account owner to provide, at a moment in time, valuations of the portfolio together with details of each financial instrument holding.
/// The account servicer/owner relationship may be:
/// - an accounting agent acting on behalf of an account owner, or
/// - a transfer agent acting on behalf of a fund manager or an account owner's designated agent.
/// Usage
/// The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner.
/// The message can be sent either audited or un-audited and may be provided on a trade date, contractual or settlement date basis. 
/// This message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, the message can be used to either specify holdings at
/// - the main account level, or, 
/// - the sub-account level.
/// This message can be used to report where the financial instruments are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated. 
/// The SecuritiesBalanceAccountingReport message should not be used for trading purposes.
/// There may be one or more intermediary parties, for example, an intermediary or a concentrator between the account owner and account servicer.
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope |An account servicer sends a SecuritiesBalanceAccountingReport to an account owner to provide, at a moment in time, valuations of the portfolio together with details of each financial instrument holding.|The account servicer/owner relationship may be:|- an accounting agent acting on behalf of an account owner, or|- a transfer agent acting on behalf of a fund manager or an account owner's designated agent.||Usage|The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner.|The message can be sent either audited or un-audited and may be provided on a trade date, contractual or settlement date basis. |This message can only be used to list the holdings of a single (master) account. However, it is possible to break down these holdings into one or several sub-accounts. Therefore, the message can be used to either specify holdings at|- the main account level, or, |- the sub-account level.|This message can be used to report where the financial instruments are safe-kept, physically or notionally. If a security is held in more than one safekeeping place, this can also be indicated. |The SecuritiesBalanceAccountingReport message should not be used for trading purposes.|There may be one or more intermediary parties, for example, an intermediary or a concentrator between the account owner and account servicer.|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information using the relevant elements in the Business Application Header.")]
public partial record SecuritiesBalanceAccountingReport002V11 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesBalAcctgRpt";
    
    #nullable enable
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_ch565ji8Eeydid5dcNPKvg")]
    [Description(@"Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required Pagination1 Pagination { get; init; }
    
    /// <summary>
    /// Provides general information on the report.
    /// </summary>
    [IsoId("_ch566Di8Eeydid5dcNPKvg")]
    [Description(@"Provides general information on the report.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    [Required]
    public required Statement76 StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_ch566ji8Eeydid5dcNPKvg")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public PartyIdentification156? AccountOwner { get; init; }
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is, manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_ch567Di8Eeydid5dcNPKvg")]
    [Description(@"Party that manages the account on behalf of the account owner, that is, manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.")]
    [DataMember(Name="AcctSvcr")]
    [XmlElement(ElementName="AcctSvcr")]
    public PartyIdentification157? AccountServicer { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_ch567ji8Eeydid5dcNPKvg")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    public SecuritiesAccount42? SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_ch568Di8Eeydid5dcNPKvg")]
    [Description(@"Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.")]
    [DataMember(Name="BlckChainAdrOrWllt")]
    [XmlElement(ElementName="BlckChainAdrOrWllt")]
    public BlockChainAddressWallet10? BlockChainAddressOrWallet { get; init; }
    
    /// <summary>
    /// Information about the party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_ch568ji8Eeydid5dcNPKvg")]
    [Description(@"Information about the party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.")]
    [DataMember(Name="IntrmyInf")]
    [XmlElement(ElementName="IntrmyInf")]
    public required IReadOnlyCollection<Intermediary45> IntermediaryInformation { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_ch569Di8Eeydid5dcNPKvg")]
    [Description(@"Net position of a segregated holding, in a single security, within the overall position held in a securities account.")]
    [DataMember(Name="BalForAcct")]
    [XmlElement(ElementName="BalForAcct")]
    public AggregateBalanceInformation43? BalanceForAccount { get; init; }
    
    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_ch569ji8Eeydid5dcNPKvg")]
    [Description(@"Sub-account of the safekeeping or investment account.")]
    [DataMember(Name="SubAcctDtls")]
    [XmlElement(ElementName="SubAcctDtls")]
    public SubAccountIdentification68? SubAccountDetails { get; init; }
    
    /// <summary>
    /// Total valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_ch56-Di8Eeydid5dcNPKvg")]
    [Description(@"Total valuation amounts provided in the base currency of the account.")]
    [DataMember(Name="AcctBaseCcyTtlAmts")]
    [XmlElement(ElementName="AcctBaseCcyTtlAmts")]
    public TotalValueInPageAndStatement4? AccountBaseCurrencyTotalAmounts { get; init; }
    
    /// <summary>
    /// Total valuation amounts provided in a currency other than the base currency of the account.
    /// </summary>
    [IsoId("_ch56-ji8Eeydid5dcNPKvg")]
    [Description(@"Total valuation amounts provided in a currency other than the base currency of the account.")]
    [DataMember(Name="AltrnRptgCcyTtlAmts")]
    [XmlElement(ElementName="AltrnRptgCcyTtlAmts")]
    public TotalValueInPageAndStatement4? AlternateReportingCurrencyTotalAmounts { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesBalanceAccountingReport002V11Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesBalanceAccountingReport002V11Document ToDocument()
    {
        return new SecuritiesBalanceAccountingReport002V11Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesBalanceAccountingReport002V11"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesBalanceAccountingReport002V11Document : IOuterDocument<SecuritiesBalanceAccountingReport002V11>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.003.002.11";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesBalanceAccountingReport002V11"/> is required.
    /// </summary>
    public required SecuritiesBalanceAccountingReport002V11 Message { get; init; }
}
