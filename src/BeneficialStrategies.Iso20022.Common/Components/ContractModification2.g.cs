﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContractModification2.  ISO2002 ID# _q0Gzca4FEemB_csI4yyKLA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the action type.
/// </summary>
public partial record ContractModification2
     : IIsoXmlSerilizable<ContractModification2>
{
    #nullable enable
    
    /// <summary>
    /// Indication of the action type of the transaction.
    /// </summary>
    public required TransactionOperationType5Code ActionType { get; init; } 
    /// <summary>
    /// Indication whether the report is done at trade or position level.
    /// </summary>
    public ModificationLevel1Code? Level { get; init; } 
    
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
        writer.WriteStartElement(null, "ActnTp", xmlNamespace );
        writer.WriteValue(ActionType.ToString()); // Enum value
        writer.WriteEndElement();
        if (Level is ModificationLevel1Code LevelValue)
        {
            writer.WriteStartElement(null, "Lvl", xmlNamespace );
            writer.WriteValue(LevelValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static ContractModification2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
