﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalParameters27.  ISO2002 ID# _6SWxr5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies additional parameters to the message or transaction.
/// </summary>
public partial record AdditionalParameters27
     : IIsoXmlSerilizable<AdditionalParameters27>
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether there exists a pre-confirmation.
    /// </summary>
    public PreConfirmation1Code? PreConfirmation { get; init; } 
    /// <summary>
    /// Specifies partial settlement information.
    /// </summary>
    public PartialSettlement2Code? PartialSettlement { get; init; } 
    /// <summary>
    /// Identification of the confirmation previously sent to confirm the partial settlement of a transaction.
    /// </summary>
    public IsoRestrictedFINXMax16Text? PreviousPartialConfirmationIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the triparty agent's point of view.
    /// </summary>
    public IsoRestrictedFINXMax16Text? TripartyAgentCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client's point of view.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ClientTripartyCollateralTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the client.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ClientCollateralInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification assigned to the instruction by the triparty agent.
    /// </summary>
    public IsoRestrictedFINXMax16Text? TripartyCollateralInstructionIdentification { get; init; } 
    
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
        if (PreConfirmation is PreConfirmation1Code PreConfirmationValue)
        {
            writer.WriteStartElement(null, "PreConf", xmlNamespace );
            writer.WriteValue(PreConfirmationValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PartialSettlement is PartialSettlement2Code PartialSettlementValue)
        {
            writer.WriteStartElement(null, "PrtlSttlm", xmlNamespace );
            writer.WriteValue(PartialSettlementValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PreviousPartialConfirmationIdentification is IsoRestrictedFINXMax16Text PreviousPartialConfirmationIdentificationValue)
        {
            writer.WriteStartElement(null, "PrvsPrtlConfId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(PreviousPartialConfirmationIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (TripartyAgentCollateralTransactionIdentification is IsoRestrictedFINXMax16Text TripartyAgentCollateralTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "TrptyAgtCollTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(TripartyAgentCollateralTransactionIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (ClientTripartyCollateralTransactionIdentification is IsoRestrictedFINXMax16Text ClientTripartyCollateralTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "ClntTrptyCollTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(ClientTripartyCollateralTransactionIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (ClientCollateralInstructionIdentification is IsoRestrictedFINXMax16Text ClientCollateralInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "ClntCollInstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(ClientCollateralInstructionIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
        if (TripartyCollateralInstructionIdentification is IsoRestrictedFINXMax16Text TripartyCollateralInstructionIdentificationValue)
        {
            writer.WriteStartElement(null, "TrptyCollInstrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax16Text(TripartyCollateralInstructionIdentificationValue)); // data type RestrictedFINXMax16Text System.String
            writer.WriteEndElement();
        }
    }
    public static AdditionalParameters27 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
