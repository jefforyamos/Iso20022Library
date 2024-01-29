﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCANOEligibleBalanceSD1V06.  ISO2002 ID# _I7uegZCEEeaSk9d1hvTrHg.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCANOEligibleBalanceSD1 message extends ISO corporate action notification (Eligible Balance market practice) message with DTCC corporate action eligible balance elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCANOEligibleBalanceSD1 message extends ISO corporate action notification (Eligible Balance market practice) message with DTCC corporate action eligible balance elements not covered in the standard message.")]
public partial record DTCCCANOEligibleBalanceSD1V06 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCANOElgblBalSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Information to be extended as supplementary data to general information.
    /// </summary>
    [IsoId("_I7ueg5CEEeaSk9d1hvTrHg")]
    [Description(@"Information to be extended as supplementary data to general information.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    public SomeCorporateActionGeneralInformationRecord? CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_I7uehZCEEeaSk9d1hvTrHg")]
    [Description(@"Information to be extended as supplementary data to underlying security details.")]
    [DataMember(Name="UndrlygScty")]
    [XmlElement(ElementName="UndrlygScty")]
    public SomeUnderlyingSecurityRecord? UnderlyingSecurity { get; init; }
    
    /// <summary>
    /// Extension block for the information to be extended as account balance for distribution events.
    /// </summary>
    [IsoId("_I7ueh5CEEeaSk9d1hvTrHg")]
    [Description(@"Extension block for the information to be extended as account balance for distribution events.")]
    [DataMember(Name="DstrbtnAcctBal")]
    [XmlElement(ElementName="DstrbtnAcctBal")]
    public SomeDistributionAccountBalanceRecord? DistributionAccountBalance { get; init; }
    
    /// <summary>
    /// Extension block for the information to be extended as account balance for redemptions events.
    /// </summary>
    [IsoId("_I7ueiZCEEeaSk9d1hvTrHg")]
    [Description(@"Extension block for the information to be extended as account balance for redemptions events.")]
    [DataMember(Name="RedAcctBal")]
    [XmlElement(ElementName="RedAcctBal")]
    public SomeRedemptionAccountBalanceRecord? RedemptionAccountBalance { get; init; }
    
    /// <summary>
    /// Extension block for the information to be extended as account balance for reorganisation events.
    /// </summary>
    [IsoId("_WzNvUJEfEeajS_7NioJdVA")]
    [Description(@"Extension block for the information to be extended as account balance for reorganisation events.")]
    [DataMember(Name="ReorgAcctBal")]
    [XmlElement(ElementName="ReorgAcctBal")]
    public SomeReorganisationAccountBalanceRecord? ReorganisationAccountBalance { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCANOEligibleBalanceSD1V06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCANOEligibleBalanceSD1V06Document ToDocument()
    {
        return new DTCCCANOEligibleBalanceSD1V06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCANOEligibleBalanceSD1V06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCANOEligibleBalanceSD1V06Document : IOuterDocument<DTCCCANOEligibleBalanceSD1V06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.007.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCANOEligibleBalanceSD1V06"/> is required.
    /// </summary>
    public required DTCCCANOEligibleBalanceSD1V06 Message { get; init; }
}