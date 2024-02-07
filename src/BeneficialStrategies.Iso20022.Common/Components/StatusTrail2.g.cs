﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusTrail2.  ISO2002 ID# _0e6CsglIEeGATtfOBToyew_246812455.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the history of status and reasons for a pending, posted or cancelled transaction.
/// </summary>
public partial record StatusTrail2
     : IIsoXmlSerilizable<StatusTrail2>
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    public required IsoISODateTime StatusDate { get; init; } 
    /// <summary>
    /// Unique and unambiguous way to identify the organisation that sent the message instance.
    /// </summary>
    public OrganisationIdentification7? SendingOrganisationIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous way to identify the user that created the message instance.
    /// </summary>
    public IsoMax35Text? UserIdentification { get; init; } 
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    public ProcessingStatus19Choice_? ProcessingStatus { get; init; } 
    /// <summary>
    /// Provides the matching status of an instruction as per the account servicer or the Market Infrastructure based on an allegement. At this time no matching took place on the market (at the CSD/ICSD/MI).
    /// </summary>
    public MatchingStatus7Choice_? InferredMatchingStatus { get; init; } 
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    public MatchingStatus7Choice_? MatchingStatus { get; init; } 
    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    public SettlementStatus7Choice_? SettlementStatus { get; init; } 
    /// <summary>
    /// Provides details on the modification processing status of the transaction.
    /// </summary>
    public ModificationProcessingStatus2Choice_? ModificationProcessingStatus { get; init; } 
    /// <summary>
    /// Provides details on the processing status of the cancellation request.
    /// </summary>
    public ProcessingStatus20Choice_? CancellationStatus { get; init; } 
    /// <summary>
    /// Status is settled.
    /// </summary>
    public ProprietaryReason1? Settled { get; init; } 
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
        writer.WriteStartElement(null, "StsDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(StatusDate)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (SendingOrganisationIdentification is OrganisationIdentification7 SendingOrganisationIdentificationValue)
        {
            writer.WriteStartElement(null, "SndgOrgId", xmlNamespace );
            SendingOrganisationIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UserIdentification is IsoMax35Text UserIdentificationValue)
        {
            writer.WriteStartElement(null, "UsrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(UserIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ProcessingStatus is ProcessingStatus19Choice_ ProcessingStatusValue)
        {
            writer.WriteStartElement(null, "PrcgSts", xmlNamespace );
            ProcessingStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InferredMatchingStatus is MatchingStatus7Choice_ InferredMatchingStatusValue)
        {
            writer.WriteStartElement(null, "IfrrdMtchgSts", xmlNamespace );
            InferredMatchingStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (MatchingStatus is MatchingStatus7Choice_ MatchingStatusValue)
        {
            writer.WriteStartElement(null, "MtchgSts", xmlNamespace );
            MatchingStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementStatus is SettlementStatus7Choice_ SettlementStatusValue)
        {
            writer.WriteStartElement(null, "SttlmSts", xmlNamespace );
            SettlementStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ModificationProcessingStatus is ModificationProcessingStatus2Choice_ ModificationProcessingStatusValue)
        {
            writer.WriteStartElement(null, "ModPrcgSts", xmlNamespace );
            ModificationProcessingStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CancellationStatus is ProcessingStatus20Choice_ CancellationStatusValue)
        {
            writer.WriteStartElement(null, "CxlSts", xmlNamespace );
            CancellationStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Settled is ProprietaryReason1 SettledValue)
        {
            writer.WriteStartElement(null, "Sttld", xmlNamespace );
            SettledValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static StatusTrail2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
