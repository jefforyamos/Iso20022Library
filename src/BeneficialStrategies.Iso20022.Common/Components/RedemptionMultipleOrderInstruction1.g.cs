﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RedemptionMultipleOrderInstruction1.  ISO2002 ID# _U2ucZNp-Ed-ak6NoX_4Aeg_67130856.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a redemption multiple order.
/// </summary>
public partial record RedemptionMultipleOrderInstruction1
     : IIsoXmlSerilizable<RedemptionMultipleOrderInstruction1>
{
    #nullable enable
    
    /// <summary>
    /// General information related to the order.
    /// </summary>
    public required RedemptionMultipleOrder2 MultipleOrderDetails { get; init; } 
    /// <summary>
    /// Information related to an intermediary.
    /// </summary>
    public ValueList<Intermediary4> IntermediaryDetails { get; init; } = [];
    /// <summary>
    /// Message is a copy.
    /// </summary>
    public CopyInformation1? CopyDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public Extension1? Extension { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "MltplOrdrDtls", xmlNamespace );
        MultipleOrderDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IntrmyDtls", xmlNamespace );
        IntermediaryDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CopyDetails is CopyInformation1 CopyDetailsValue)
        {
            writer.WriteStartElement(null, "CpyDtls", xmlNamespace );
            CopyDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Extension is Extension1 ExtensionValue)
        {
            writer.WriteStartElement(null, "Xtnsn", xmlNamespace );
            ExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static RedemptionMultipleOrderInstruction1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
