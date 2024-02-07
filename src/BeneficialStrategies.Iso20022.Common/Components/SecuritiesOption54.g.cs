﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOption54.  ISO2002 ID# _cheM5ZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the security option of a corporate event.
/// </summary>
public partial record SecuritiesOption54
     : IIsoXmlSerilizable<SecuritiesOption54>
{
    #nullable enable
    
    /// <summary>
    /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? ConditionalQuantity { get; init; } 
    /// <summary>
    /// Quantity of securities to which this instruction applies.
    /// </summary>
    public required Quantity40Choice_ InstructedQuantity { get; init; } 
    
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
        if (ConditionalQuantity is FinancialInstrumentQuantity15Choice_ ConditionalQuantityValue)
        {
            writer.WriteStartElement(null, "CondlQty", xmlNamespace );
            ConditionalQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "InstdQty", xmlNamespace );
        InstructedQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static SecuritiesOption54 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
