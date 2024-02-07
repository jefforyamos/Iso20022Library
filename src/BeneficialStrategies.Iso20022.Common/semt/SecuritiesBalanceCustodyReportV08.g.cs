﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesBalanceCustodyReportV08.  ISO2002 ID# _FYQ9oU3NEeS1yPC0JC-FvQ.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.semt.SecuritiesBalanceCustodyReportV08>;

namespace BeneficialStrategies.Iso20022.semt;


/// <summary>
/// This record is an implementation of the semt.002.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|An account servicer sends a SecuritiesBalanceCustodyReport to an account owner to provide, at a moment in time, the quantity and identification of the financial instruments that the account servicer holds for the account owner.||The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants, or|- an agent (sub-custodian) acting on behalf of their global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer, or|- a transfer agent acting on behalf of a fund manager or an account owner's designated agent.||Usage|The message can also include availability and the location of holdings to facilitate trading and minimise settlement issues. The message reports all information per financial instrument, that is, when a financial instrument is held at multiple places of safekeeping, the total holdings for all locations can be provided. |The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner. The message may be provided on a trade date, contractual or settlement date basis. |There may be one or more intermediary parties, for example, an intermediary or a concentrator between the account owner and account servicer.|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Serializable]
[Description(@"Scope|An account servicer sends a SecuritiesBalanceCustodyReport to an account owner to provide, at a moment in time, the quantity and identification of the financial instruments that the account servicer holds for the account owner.||The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants, or|- an agent (sub-custodian) acting on behalf of their global custodian customer, or |- a custodian acting on behalf of an investment management institution or a broker/dealer, or|- a transfer agent acting on behalf of a fund manager or an account owner's designated agent.||Usage|The message can also include availability and the location of holdings to facilitate trading and minimise settlement issues. The message reports all information per financial instrument, that is, when a financial instrument is held at multiple places of safekeeping, the total holdings for all locations can be provided. |The message should be sent at a frequency agreed bi-laterally between the account servicer and the account owner. The message may be provided on a trade date, contractual or settlement date basis. |There may be one or more intermediary parties, for example, an intermediary or a concentrator between the account owner and account servicer.|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
public partial record SecuritiesBalanceCustodyReportV08 : IOuterRecord<SecuritiesBalanceCustodyReportV08,SecuritiesBalanceCustodyReportV08Document>
    ,IIsoXmlSerilizable<SecuritiesBalanceCustodyReportV08>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.002.001.08";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesBalCtdyRpt";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesBalanceCustodyReportV08Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_FYQ9r03NEeS1yPC0JC-FvQ")]
    [Description(@"Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required Pagination Pagination { get; init; }
    
    /// <summary>
    /// Provides general information on the report.
    /// </summary>
    [IsoId("_FYQ9sU3NEeS1yPC0JC-FvQ")]
    [Description(@"Provides general information on the report.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    [Required]
    public required Statement33 StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_FYQ9s03NEeS1yPC0JC-FvQ")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public PartyIdentification36Choice_? AccountOwner { get; init; }
    
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.|.
    /// </summary>
    [IsoId("_FYQ9tU3NEeS1yPC0JC-FvQ")]
    [Description(@"Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.|.")]
    [DataMember(Name="AcctSvcr")]
    [XmlElement(ElementName="AcctSvcr")]
    public PartyIdentification49Choice_? AccountServicer { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_FYQ9t03NEeS1yPC0JC-FvQ")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    [Required]
    public required SecuritiesAccount11 SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Information about the party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.
    /// </summary>
    [IsoId("_FYQ9uU3NEeS1yPC0JC-FvQ")]
    [Description(@"Information about the party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.")]
    [DataMember(Name="IntrmyInf")]
    [XmlElement(ElementName="IntrmyInf")]
    public required ValueList<Intermediary23> IntermediaryInformation { get; init; } = []; // Min=0, Max=10
    
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    [IsoId("_FYQ9u03NEeS1yPC0JC-FvQ")]
    [Description(@"Net position of a segregated holding, in a single security, within the overall position held in a securities account.")]
    [DataMember(Name="BalForAcct")]
    [XmlElement(ElementName="BalForAcct")]
    public AggregateBalanceInformation25? BalanceForAccount { get; init; }
    
    /// <summary>
    /// Sub-account of the safekeeping or investment account.
    /// </summary>
    [IsoId("_FYQ9vU3NEeS1yPC0JC-FvQ")]
    [Description(@"Sub-account of the safekeeping or investment account.")]
    [DataMember(Name="SubAcctDtls")]
    [XmlElement(ElementName="SubAcctDtls")]
    public SubAccountIdentification37? SubAccountDetails { get; init; }
    
    /// <summary>
    /// Total valuation amounts provided in the base currency of the account.
    /// </summary>
    [IsoId("_FYQ9v03NEeS1yPC0JC-FvQ")]
    [Description(@"Total valuation amounts provided in the base currency of the account.")]
    [DataMember(Name="AcctBaseCcyTtlAmts")]
    [XmlElement(ElementName="AcctBaseCcyTtlAmts")]
    public TotalValueInPageAndStatement1? AccountBaseCurrencyTotalAmounts { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesBalanceCustodyReportV08Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesBalanceCustodyReportV08Document ToDocument()
    {
        return new SecuritiesBalanceCustodyReportV08Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SctiesBalCtdyRpt");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Pgntn", xmlNamespace );
        Pagination.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "StmtGnlDtls", xmlNamespace );
        StatementGeneralDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AccountOwner is PartyIdentification36Choice_ AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountServicer is PartyIdentification49Choice_ AccountServicerValue)
        {
            writer.WriteStartElement(null, "AcctSvcr", xmlNamespace );
            AccountServicerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        SafekeepingAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IntrmyInf", xmlNamespace );
        IntermediaryInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (BalanceForAccount is AggregateBalanceInformation25 BalanceForAccountValue)
        {
            writer.WriteStartElement(null, "BalForAcct", xmlNamespace );
            BalanceForAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SubAccountDetails is SubAccountIdentification37 SubAccountDetailsValue)
        {
            writer.WriteStartElement(null, "SubAcctDtls", xmlNamespace );
            SubAccountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountBaseCurrencyTotalAmounts is TotalValueInPageAndStatement1 AccountBaseCurrencyTotalAmountsValue)
        {
            writer.WriteStartElement(null, "AcctBaseCcyTtlAmts", xmlNamespace );
            AccountBaseCurrencyTotalAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesBalanceCustodyReportV08 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesBalanceCustodyReportV08"/>.
/// </summary>
[Serializable]
public partial record SecuritiesBalanceCustodyReportV08Document : IOuterDocument<SecuritiesBalanceCustodyReportV08>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.002.001.08";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesBalanceCustodyReportV08"/> is required.
    /// </summary>
    [DataMember(Name=SecuritiesBalanceCustodyReportV08.XmlTag)]
    public required SecuritiesBalanceCustodyReportV08 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SecuritiesBalanceCustodyReportV08.XmlTag);
        Message.Serialize(writer, DocumentNamespace);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
    }
    
    public void ReadXml(XmlReader reader)
    {
        throw new NotImplementedException();
    }
    
    public System.Xml.Schema.XmlSchema GetSchema() => null;
}
