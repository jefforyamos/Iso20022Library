﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AccountHoldingInformationV02.  ISO2002 ID# _QJo8ofpcEeCPwaG9zjUPNQ.
//
namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// Scope
/// An executing party, eg, a (old) plan manager (Transferor), sends the AccountHoldingInformation message to the instructing party, eg, a (new) plan manager (Transferee), to provide information about financial instruments held on behalf of a client.
/// Usage
/// The AccountHoldingInformation message is used to provide information about one or more ISA or portfolio products held in a client's account.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|An executing party, eg, a (old) plan manager (Transferor), sends the AccountHoldingInformation message to the instructing party, eg, a (new) plan manager (Transferee), to provide information about financial instruments held on behalf of a client.|Usage|The AccountHoldingInformation message is used to provide information about one or more ISA or portfolio products held in a client's account.")]
public partial record AccountHoldingInformationV02 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctHldgInf";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Identifies the message.
    /// </summary>
    [IsoId("_QJo8vfpcEeCPwaG9zjUPNQ")]
    [Description(@"Identifies the message.")]
    [DataMember(Name="MsgRef")]
    [XmlElement(ElementName="MsgRef")]
    [Required]
    public required MessageIdentification1 MessageReference { get; init; }
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_QJo8wfpcEeCPwaG9zjUPNQ")]
    [Description(@"Collective reference identifying a set of messages.")]
    [DataMember(Name="PoolRef")]
    [XmlElement(ElementName="PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_QJo8xfpcEeCPwaG9zjUPNQ")]
    [Description(@"Reference to a linked message that was previously sent.")]
    [DataMember(Name="PrvsRef")]
    [XmlElement(ElementName="PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_QJo8yfpcEeCPwaG9zjUPNQ")]
    [Description(@"Reference to a linked message that was previously received.")]
    [DataMember(Name="RltdRef")]
    [XmlElement(ElementName="RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }
    
    /// <summary>
    /// Identifies the business flow direction type (assets to be delivered or received).
    /// </summary>
    [IsoId("_egpsL_slEeCIi9ZETLBv8g")]
    [Description(@"Identifies the business flow direction type (assets to be delivered or received).")]
    [DataMember(Name="BizFlowDrctnTp")]
    [XmlElement(ElementName="BizFlowDrctnTp")]
    public BusinessFlowDirectionType1Code? BusinessFlowDirectionType { get; init; }
    
    /// <summary>
    /// Information identifying the primary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_QJo8zfpcEeCPwaG9zjUPNQ")]
    [Description(@"Information identifying the primary individual investor, eg, name, address, social security number and date of birth.")]
    [DataMember(Name="PmryIndvInvstr")]
    [XmlElement(ElementName="PmryIndvInvstr")]
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_QJo80fpcEeCPwaG9zjUPNQ")]
    [Description(@"Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.")]
    [DataMember(Name="ScndryIndvInvstr")]
    [XmlElement(ElementName="ScndryIndvInvstr")]
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying other individual investors, eg, name, address, social security number and date of birth.
    /// </summary>
    [IsoId("_QJo81fpcEeCPwaG9zjUPNQ")]
    [Description(@"Information identifying other individual investors, eg, name, address, social security number and date of birth.")]
    [DataMember(Name="OthrIndvInvstr")]
    [XmlElement(ElementName="OthrIndvInvstr")]
    public IndividualPerson8? OtherIndividualInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the primary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_QJo82fpcEeCPwaG9zjUPNQ")]
    [Description(@"Information identifying the primary corporate investor, eg, name and address.")]
    [DataMember(Name="PmryCorpInvstr")]
    [XmlElement(ElementName="PmryCorpInvstr")]
    public Organisation4? PrimaryCorporateInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the secondary corporate investor, eg, name and address.
    /// </summary>
    [IsoId("_QJo83fpcEeCPwaG9zjUPNQ")]
    [Description(@"Information identifying the secondary corporate investor, eg, name and address.")]
    [DataMember(Name="ScndryCorpInvstr")]
    [XmlElement(ElementName="ScndryCorpInvstr")]
    public Organisation4? SecondaryCorporateInvestor { get; init; }
    
    /// <summary>
    /// Information identifying the other corporate investors, eg, name and address.
    /// </summary>
    [IsoId("_QJo84fpcEeCPwaG9zjUPNQ")]
    [Description(@"Information identifying the other corporate investors, eg, name and address.")]
    [DataMember(Name="OthrCorpInvstr")]
    [XmlElement(ElementName="OthrCorpInvstr")]
    public Organisation4? OtherCorporateInvestor { get; init; }
    
    /// <summary>
    /// Identification of an account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    [IsoId("_QJo85fpcEeCPwaG9zjUPNQ")]
    [Description(@"Identification of an account owned by the investor at the old plan manager (account servicer).")]
    [DataMember(Name="TrfrAcct")]
    [XmlElement(ElementName="TrfrAcct")]
    [Required]
    public required Account5 TransferorAccount { get; init; }
    
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_QJo86fpcEeCPwaG9zjUPNQ")]
    [Description(@"Account held in the name of a party that is not the name of the beneficial owner of the shares.")]
    [DataMember(Name="NmneeAcct")]
    [XmlElement(ElementName="NmneeAcct")]
    public Account6? NomineeAccount { get; init; }
    
    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    [IsoId("_QJo87fpcEeCPwaG9zjUPNQ")]
    [Description(@"Information related to the institution to which the financial instrument is to be transferred.")]
    [DataMember(Name="Trfee")]
    [XmlElement(ElementName="Trfee")]
    [Required]
    public required IPartyIdentification2Choice Transferee { get; init; }
    
    /// <summary>
    /// Provides information related to the asset(s) transferred.
    /// </summary>
    [IsoId("_QJo88fpcEeCPwaG9zjUPNQ")]
    [Description(@"Provides information related to the asset(s) transferred.")]
    [DataMember(Name="PdctTrf")]
    [XmlElement(ElementName="PdctTrf")]
    [Required]
    public required ISATransfer4 ProductTransfer { get; init; }
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_QJo89fpcEeCPwaG9zjUPNQ")]
    [Description(@"Additional information that can not be captured in the structured fields and/or any other specific block.")]
    [DataMember(Name="Xtnsn")]
    [XmlElement(ElementName="Xtnsn")]
    public Extension1? Extension { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AccountHoldingInformationV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AccountHoldingInformationV02Document ToDocument()
    {
        return new AccountHoldingInformationV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AccountHoldingInformationV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AccountHoldingInformationV02Document : IOuterDocument<AccountHoldingInformationV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.018.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AccountHoldingInformationV02"/> is required.
    /// </summary>
    public required AccountHoldingInformationV02 Message { get; init; }
}
