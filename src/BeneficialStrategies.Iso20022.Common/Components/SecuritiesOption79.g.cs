﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesOption79.  ISO2002 ID# _N-tRJRuyEeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies securities quantities for corporate action instruction.
/// </summary>
public partial record SecuritiesOption79
     : IIsoXmlSerilizable<SecuritiesOption79>
{
    #nullable enable
    
    /// <summary>
    /// Minimum quantity of securities to be accepted (used in the framework of conditional privilege on election). In case of proration, if this minimum quantity is not reached then the instruction is void.
    /// </summary>
    public FinancialInstrumentQuantity33Choice_? ConditionalQuantity { get; init; } 
    /// <summary>
    /// Quantity of securities to which this instruction applies.
    /// </summary>
    public required Quantity52Choice_ InstructedQuantity { get; init; } 
    /// <summary>
    /// Quantity of additional shares requested due to the difference of “round-up against payment” practice between the account servicer and the account holder (for instance for French dividend option).
    /// </summary>
    public FinancialInstrumentQuantity33Choice_? AdditionalRoundUpQuantity { get; init; } 
    
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
        if (ConditionalQuantity is FinancialInstrumentQuantity33Choice_ ConditionalQuantityValue)
        {
            writer.WriteStartElement(null, "CondlQty", xmlNamespace );
            ConditionalQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "InstdQty", xmlNamespace );
        InstructedQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalRoundUpQuantity is FinancialInstrumentQuantity33Choice_ AdditionalRoundUpQuantityValue)
        {
            writer.WriteStartElement(null, "AddtlRndUpQty", xmlNamespace );
            AdditionalRoundUpQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesOption79 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
