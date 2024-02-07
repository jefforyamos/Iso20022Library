﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ClearingSystemMemberIdentification.  ISO2002 ID# _Tet_ZSGOEeW7gKYhAMEFCw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification7Choice;

/// <summary>
/// Choice of identifier for a clearing system member, as assigned by the clearing system. In some clearing systems, the accounts of the clearing system members are also assigned an identifier.
/// </summary>
public partial record ClearingSystemMemberIdentification : FinancialInstitutionIdentification7Choice_
     , IIsoXmlSerilizable<ClearingSystemMemberIdentification>
{
    #nullable enable
    
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
    }
    public static new ClearingSystemMemberIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
