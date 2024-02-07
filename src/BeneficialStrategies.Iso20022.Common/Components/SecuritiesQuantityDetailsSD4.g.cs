﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesQuantityDetailsSD4.  ISO2002 ID# _b5LodMYOEeexPc-mfUU5zQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about securities quantity linked to a corporate action option.
/// </summary>
public partial record SecuritiesQuantityDetailsSD4
     : IIsoXmlSerilizable<SecuritiesQuantityDetailsSD4>
{
    #nullable enable
    
    /// <summary>
    /// For rights subscription events with an oversubscription feature, the quantity of the oversubscription for the given instruction.
    /// </summary>
    public FinancialInstrumentQuantity4? OversubscriptionQuantity { get; init; } 
    /// <summary>
    /// Total oversubscription quantity of all transaction sequence instructions.
    /// </summary>
    public FinancialInstrumentQuantity4? TotalOversubscriptionQuantity { get; init; } 
    /// <summary>
    /// Instruction quantity for a given transaction sequence number.
    /// </summary>
    public FinancialInstrumentQuantity31Choice_? InstructionQuantity { get; init; } 
    /// <summary>
    /// Quantity not fully covered.
    /// </summary>
    public FinancialInstrumentQuantity31Choice_? OpenUncoveredQuantity { get; init; } 
    /// <summary>
    /// Quantity covered but transactions not in "MADE" status.
    /// </summary>
    public FinancialInstrumentQuantity31Choice_? InterimCoveredQuantity { get; init; } 
    
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
        if (OversubscriptionQuantity is FinancialInstrumentQuantity4 OversubscriptionQuantityValue)
        {
            writer.WriteStartElement(null, "OvrsbcptQty", xmlNamespace );
            OversubscriptionQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalOversubscriptionQuantity is FinancialInstrumentQuantity4 TotalOversubscriptionQuantityValue)
        {
            writer.WriteStartElement(null, "TtlOvrsbcptQty", xmlNamespace );
            TotalOversubscriptionQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructionQuantity is FinancialInstrumentQuantity31Choice_ InstructionQuantityValue)
        {
            writer.WriteStartElement(null, "InstrQty", xmlNamespace );
            InstructionQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OpenUncoveredQuantity is FinancialInstrumentQuantity31Choice_ OpenUncoveredQuantityValue)
        {
            writer.WriteStartElement(null, "OpnUcvrdQty", xmlNamespace );
            OpenUncoveredQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InterimCoveredQuantity is FinancialInstrumentQuantity31Choice_ InterimCoveredQuantityValue)
        {
            writer.WriteStartElement(null, "IntrmCvrdQty", xmlNamespace );
            InterimCoveredQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesQuantityDetailsSD4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
