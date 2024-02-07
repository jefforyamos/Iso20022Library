﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMService7.  ISO2002 ID# _IAYH0Yq0EeSIDtZ76p6McQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Services allowed for the customer's profile.
/// </summary>
public partial record ATMService7
     : IIsoXmlSerilizable<ATMService7>
{
    #nullable enable
    
    /// <summary>
    /// Describes the type of inquiry selected by the customer or the ATM.
    /// </summary>
    public required ATMServiceType4Code ServiceType { get; init; } 
    /// <summary>
    /// Limits of amounts.
    /// </summary>
    public ATMTransactionAmounts3? Limits { get; init; } 
    /// <summary>
    /// Preferred withdrawal transaction chosen by the customer.
    /// </summary>
    public ATMTransaction8? PreferredWithdrawal { get; init; } 
    
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
        writer.WriteStartElement(null, "SvcTp", xmlNamespace );
        writer.WriteValue(ServiceType.ToString()); // Enum value
        writer.WriteEndElement();
        if (Limits is ATMTransactionAmounts3 LimitsValue)
        {
            writer.WriteStartElement(null, "Lmts", xmlNamespace );
            LimitsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreferredWithdrawal is ATMTransaction8 PreferredWithdrawalValue)
        {
            writer.WriteStartElement(null, "PrefrdWdrwl", xmlNamespace );
            PreferredWithdrawalValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ATMService7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
