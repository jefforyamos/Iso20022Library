﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegisteredContractJournal2.  ISO2002 ID# _EtCfVW4-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document that a user must file with an authorised servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
public partial record RegisteredContractJournal2
     : IIsoXmlSerilizable<RegisteredContractJournal2>
{
    #nullable enable
    
    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; } 
    /// <summary>
    /// Unique registered contract identification.
    /// </summary>
    public DocumentIdentification28? UniqueIdentification { get; init; } 
    /// <summary>
    /// Date of closure of the registered contract.
    /// </summary>
    public required IsoISODate ClosureDate { get; init; } 
    /// <summary>
    /// Reason of closure.
    /// </summary>
    public required ContractClosureReason1Choice_ ClosureReason { get; init; } 
    
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
        writer.WriteStartElement(null, "RegnAgt", xmlNamespace );
        RegistrationAgent.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (UniqueIdentification is DocumentIdentification28 UniqueIdentificationValue)
        {
            writer.WriteStartElement(null, "UnqId", xmlNamespace );
            UniqueIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ClsrDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(ClosureDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ClsrRsn", xmlNamespace );
        ClosureReason.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static RegisteredContractJournal2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
