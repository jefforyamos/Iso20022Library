﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DTCCCAINSD1V04.  ISO2002 ID# _LAGyL75MEeexmbB7KsjCwA.
//
namespace BeneficialStrategies.Iso20022.supl;

/// <summary>
/// The DTCCCAINSD1 message extends ISO corporate action instruction message with DTCC corporate action elements not covered in the standard message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The DTCCCAINSD1 message extends ISO corporate action instruction message with DTCC corporate action elements not covered in the standard message.")]
public partial record DTCCCAINSD1V04 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DTCCCAINSD1";
    
    /* ------------------------------------------ Underlying data types not ready yet
    /// <summary>
    /// DTC (The Depository Trust Corporation) optional dividend service election.
    /// </summary>
    [IsoId("_LAGyMb5MEeexmbB7KsjCwA")]
    [Description(@"DTC (The Depository Trust Corporation) optional dividend service election.")]
    [DataMember(Name="OptnlDvdd")]
    [XmlElement(ElementName="OptnlDvdd")]
    public SomeOptionalDividendRecord? OptionalDividend { get; init; }
    
    /// <summary>
    /// DTC (The Depository Trust Corporation) tax exempt service election.
    /// </summary>
    [IsoId("_LAGyOb5MEeexmbB7KsjCwA")]
    [Description(@"DTC (The Depository Trust Corporation) tax exempt service election.")]
    [DataMember(Name="TaxXmpt")]
    [XmlElement(ElementName="TaxXmpt")]
    public SomeTaxExemptRecord? TaxExempt { get; init; }
    
    /// <summary>
    /// DTC (The Depository Trust Corporation) foreign currency payment service wire payment instruction.
    /// </summary>
    [IsoId("_LAGyQb5MEeexmbB7KsjCwA")]
    [Description(@"DTC (The Depository Trust Corporation) foreign currency payment service wire payment instruction.")]
    [DataMember(Name="WireInstr")]
    [XmlElement(ElementName="WireInstr")]
    public SomeWireInstructionRecord? WireInstruction { get; init; }
    
    /// <summary>
    /// Supplementary data extending corporate action reorganisation instruction message with corporate action elements not covered in the standard message.
    /// </summary>
    [IsoId("_aEKXsMU2EeeWeZMpNX1JUQ")]
    [Description(@"Supplementary data extending corporate action reorganisation instruction message with corporate action elements not covered in the standard message.")]
    [DataMember(Name="ReorgInstrDtls")]
    [XmlElement(ElementName="ReorgInstrDtls")]
    public required IReadonlyCollection<SomeReorganisationInstructionDetailsRecord> ReorganisationInstructionDetails { get; init; } // Min=0, Max=12
    
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DTCCCAINSD1V04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DTCCCAINSD1V04Document ToDocument()
    {
        return new DTCCCAINSD1V04Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DTCCCAINSD1V04"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DTCCCAINSD1V04Document : IOuterDocument<DTCCCAINSD1V04>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:supl.008.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DTCCCAINSD1V04"/> is required.
    /// </summary>
    public required DTCCCAINSD1V04 Message { get; init; }
}
