﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AcceptorConfigurationUpdateV10.  ISO2002 ID# _6QnekS1vEeuZtpnZJ4v-5Q.
//
namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// The AcceptorConfigurationUpdate message is sent by a TM to a POI to update configurations.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"The AcceptorConfigurationUpdate message is sent by a TM to a POI to update configurations.")]
public partial record AcceptorConfigurationUpdateV10 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCfgtnUpd";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AcceptorConfigurationUpdateV10Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AcceptorConfigurationUpdateV10Document ToDocument()
    {
        return new AcceptorConfigurationUpdateV10Document { Message = this };
    }
}

/// <summary>
/// The AcceptorConfigurationUpdate message is sent by a TM to a POI to update configurations.
/// This is the outer document that contains <seealso cref="AcceptorConfigurationUpdateV10"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AcceptorConfigurationUpdateV10Document : IOuterDocument<AcceptorConfigurationUpdateV10>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.003.001.10";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AcceptorConfigurationUpdateV10"/> is required.
    /// </summary>
    public required AcceptorConfigurationUpdateV10 Message { get; init; }
}
