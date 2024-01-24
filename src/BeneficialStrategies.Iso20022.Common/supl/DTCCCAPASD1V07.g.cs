﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAPASD1V07.  ISO2002 ID# _I5L_8e2QEeiWtrflKsFqHg.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCAPASD1 message extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCAPASD1 message extends ISO corporate action movement preliminary advice message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAPASD1V07 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAPASD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// Extension block for the information to be extended as corporate action general information.
    /// </summary>
    [IsoId("_I5L_8-2QEeiWtrflKsFqHg")]
    [Description(@"Extension block for the information to be extended as corporate action general information.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    public SomeCorporateActionGeneralInformationRecord? CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to underlying security details.
    /// </summary>
    [IsoId("_I5VJ4e2QEeiWtrflKsFqHg")]
    [Description(@"Information to be extended as supplementary data to underlying security details.")]
    [DataMember(Name="UndrlygScty")]
    [XmlElement(ElementName="UndrlygScty")]
    public SomeUnderlyingSecurityRecord? UnderlyingSecurity { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action balance details.
    /// </summary>
    [IsoId("_I5VJ4-2QEeiWtrflKsFqHg")]
    [Description(@"Information to be extended as supplementary data to corporate action balance details.")]
    [DataMember(Name="CorpActnBalDtls")]
    [XmlElement(ElementName="CorpActnBalDtls")]
    public SomeCorporateActionBalanceDetailsRecord? CorporateActionBalanceDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action details.
    /// </summary>
    [IsoId("_I5VJ5e2QEeiWtrflKsFqHg")]
    [Description(@"Information to be extended as supplementary data to corporate action details.")]
    [DataMember(Name="CorpActnDtls")]
    [XmlElement(ElementName="CorpActnDtls")]
    public SomeCorporateActionDetailsRecord? CorporateActionDetails { get; init; }
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action movement securities movement details.
    /// </summary>
    [IsoId("_I5VJ5-2QEeiWtrflKsFqHg")]
    [Description(@"Extension block for the information to be extended as corporate action movement securities movement details.")]
    [DataMember(Name="CorpActnMvmntSctiesMvmntDtls")]
    [XmlElement(ElementName="CorpActnMvmntSctiesMvmntDtls")]
    public SomeCorporateActionMovementSecuritiesMovementDetailsRecord? CorporateActionMovementSecuritiesMovementDetails { get; init; }
    
    /// <summary>
    /// Extension block for the information to be extended as corporate action movement cash movement details.
    /// </summary>
    [IsoId("_I5VJ7-2QEeiWtrflKsFqHg")]
    [Description(@"Extension block for the information to be extended as corporate action movement cash movement details.")]
    [DataMember(Name="CorpActnMvmntCshMvmntDtls")]
    [XmlElement(ElementName="CorpActnMvmntCshMvmntDtls")]
    public SomeCorporateActionMovementCashMovementDetailsRecord? CorporateActionMovementCashMovementDetails { get; init; }
    
    /// <summary>
    /// Information to be extended as supplementary data to corporate action option details.
    /// </summary>
    [IsoId("_I5VJ9-2QEeiWtrflKsFqHg")]
    [Description(@"Information to be extended as supplementary data to corporate action option details.")]
    [DataMember(Name="OptnTxDtls")]
    [XmlElement(ElementName="OptnTxDtls")]
    public SomeOptionTransactionDetailsRecord? OptionTransactionDetails { get; init; }
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAPASD1V07Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAPASD1V07Document ToDocument()
    {
        return new DTCCCAPASD1V07Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCAPASD1V07"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCAPASD1V07Document : IOuterDocument<DTCCCAPASD1V07>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.009.001.07";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAPASD1V07"/> is required.
    /// </summary>
    public required DTCCCAPASD1V07 Message { get; init; }
}
