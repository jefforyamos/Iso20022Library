﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ActivationStatus2.  ISO2002 ID# _Ug_1x-H7Eeqbls7Gk4-ckA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the status of a debtor activation.
/// </summary>
public partial record ActivationStatus2
     : IIsoXmlSerilizable<ActivationStatus2>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the original instruction.
    /// </summary>
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; } 
    /// <summary>
    /// Provides detailed information on the status of the request.
    /// </summary>
    public required ServiceStatus1Choice_ Status { get; init; } 
    /// <summary>
    /// Specifies the reason for the status of the debtor activation request.
    /// </summary>
    public DebtorActivationStatusReason2? StatusReason { get; init; } 
    /// <summary>
    /// Provides the reference of the original activation request.
    /// </summary>
    public OriginalActivation2Choice_? OriginalActivationReference { get; init; } 
    /// <summary>
    /// Effective date when the debtor has been activated.
    /// </summary>
    public DateAndDateTime2Choice_? EffectiveActivationDate { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
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
        if (OriginalBusinessInstruction is OriginalBusinessInstruction1 OriginalBusinessInstructionValue)
        {
            writer.WriteStartElement(null, "OrgnlBizInstr", xmlNamespace );
            OriginalBusinessInstructionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Sts", xmlNamespace );
        Status.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (StatusReason is DebtorActivationStatusReason2 StatusReasonValue)
        {
            writer.WriteStartElement(null, "StsRsn", xmlNamespace );
            StatusReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalActivationReference is OriginalActivation2Choice_ OriginalActivationReferenceValue)
        {
            writer.WriteStartElement(null, "OrgnlActvtnRef", xmlNamespace );
            OriginalActivationReferenceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EffectiveActivationDate is DateAndDateTime2Choice_ EffectiveActivationDateValue)
        {
            writer.WriteStartElement(null, "FctvActvtnDt", xmlNamespace );
            EffectiveActivationDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ActivationStatus2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
