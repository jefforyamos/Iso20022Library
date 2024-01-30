﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCACOSD1V05.  ISO2002 ID# _I7vsrZCEEeaSk9d1hvTrHg.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCACOSD1 message extends ISO corporate action movement confirmation message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCACOSD1V05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCACOSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-parts confirmation is to continue or that the message is the last page of the multi-parts confirmation.
    /// </summary>
    [IsoId("_3HceIZE_EeanIpS4qvJ1tw")]
    [Description(@"Page number of the message and continuation indicator to indicate that the multi-parts confirmation is to continue or that the message is the last page of the multi-parts confirmation.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    public Pagination? Pagination { get; init; }
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action general information.
    /// </summary>
    [IsoId("_I7vsr5CEEeaSk9d1hvTrHg")]
    [Description(@"Extension block for the information to be extended as corporate action general information.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    public CorporateActionGeneralInformationSD27? CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_I7wTsZCEEeaSk9d1hvTrHg")]
    [Description(@"Information to be extended as supplementary data to underlying security details.")]
    [DataMember(Name="UndrlygScty")]
    [XmlElement(ElementName="UndrlygScty")]
    public FinancialInstrumentAttributesSD9? UnderlyingSecurity { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_I7wTs5CEEeaSk9d1hvTrHg")]
    [Description(@"Information to be extended as supplementary data to corporate action details.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public CorporateActionSD16? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Extension block for the information to be extended as account balance.
    /// </summary>
    [IsoId("_I7wTtZCEEeaSk9d1hvTrHg")]
    [Description(@"Extension block for the information to be extended as account balance.")]
    [DataMember(Name="AcctBal")]
    [XmlElement(ElementName="AcctBal")]
    public AccountBalanceSD9? AccountBalance { get; init; }
    
    /// <summary>
    /// Information to be extended as corporate action confirmation details.
    /// </summary>
    [IsoId("_4yXyEJFDEeanIpS4qvJ1tw")]
    [Description(@"Information to be extended as corporate action confirmation details.")]
    [DataMember(Name="CorpActnConfDtls")]
    [XmlElement(ElementName="CorpActnConfDtls")]
    public CorporateActionConfirmationDetailsSD1? CorporateActionConfirmationDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as corporate action confirmation securities movement details.
    /// </summary>
    [IsoId("_I7wTt5CEEeaSk9d1hvTrHg")]
    [Description(@"Information to be extended as corporate action confirmation securities movement details.")]
    [DataMember(Name="CorpActnConfSctiesMvmntDtls")]
    [XmlElement(ElementName="CorpActnConfSctiesMvmntDtls")]
    public CorporateActionConfirmationSecuritiesMovementDetailsSD5? CorporateActionConfirmationSecuritiesMovementDetails { get; init; }
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action confirmation cash movement details.
    /// </summary>
    [IsoId("_I7wTv5CEEeaSk9d1hvTrHg")]
    [Description(@"Extension block for the information to be extended as corporate action confirmation cash movement details.")]
    [DataMember(Name="CorpActnConfCshMvmntDtls")]
    [XmlElement(ElementName="CorpActnConfCshMvmntDtls")]
    public CorporateActionConfirmationCashMovementDetailsSD4? CorporateActionConfirmationCashMovementDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action option details.
    /// </summary>
    [IsoId("_MrdVAZFHEeanIpS4qvJ1tw")]
    [Description(@"Information to be extended as supplementary data to corporate action option details.")]
    [DataMember(Name="OptnTxDtls")]
    [XmlElement(ElementName="OptnTxDtls")]
    public OptionTransactionDetailsSD2? OptionTransactionDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCACOSD1V05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCACOSD1V05Document ToDocument()
    {
        return new DTCCCACOSD1V05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCACOSD1V05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCACOSD1V05Document : IOuterDocument<DTCCCACOSD1V05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.011.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCACOSD1V05"/> is required.
    /// </summary>
    public required DTCCCACOSD1V05 Message { get; init; }
}
