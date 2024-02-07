﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RegisteredContract6.  ISO2002 ID# _EXwBT249EeiU9cctagi5ow.
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
public partial record RegisteredContract6
     : IIsoXmlSerilizable<RegisteredContract6>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the registered contract closure.
    /// </summary>
    public required IsoMax35Text RegisteredContractClosureIdentification { get; init; } 
    /// <summary>
    /// Party who registered the currency control contract.
    /// </summary>
    public required TradeParty5 ReportingParty { get; init; } 
    /// <summary>
    /// Agent who registered the currency control contract.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 RegistrationAgent { get; init; } 
    /// <summary>
    /// Original registered contract identification.
    /// </summary>
    public required DocumentIdentification29 OriginalRegisteredContract { get; init; } 
    /// <summary>
    /// Priority of the registered contract closure.
    /// </summary>
    public required Priority2Code Priority { get; init; } 
    /// <summary>
    /// Reason of the closure.
    /// </summary>
    public required ContractClosureReason1Choice_ ClosureReason { get; init; } 
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
        writer.WriteStartElement(null, "RegdCtrctClsrId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(RegisteredContractClosureIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RptgPty", xmlNamespace );
        ReportingParty.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RegnAgt", xmlNamespace );
        RegistrationAgent.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OrgnlRegdCtrct", xmlNamespace );
        OriginalRegisteredContract.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Prty", xmlNamespace );
        writer.WriteValue(Priority.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ClsrRsn", xmlNamespace );
        ClosureReason.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static RegisteredContract6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
