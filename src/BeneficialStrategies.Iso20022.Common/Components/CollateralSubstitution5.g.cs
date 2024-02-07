﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralSubstitution5.  ISO2002 ID# _1LsPEYFvEeWtPe6Crjmeug.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the collateral that will be substituted.
/// </summary>
public partial record CollateralSubstitution5
     : IIsoXmlSerilizable<CollateralSubstitution5>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the collateral substitution request is new or updated.
    /// </summary>
    public required CollateralSubstitutionSequence1Code CollateralSubstitutionSequence { get; init; } 
    /// <summary>
    /// Cash value of the requested collateral substitution transfer in the base currency.
    /// </summary>
    public required IsoActiveCurrencyAndAmount SubstitutionRequirement { get; init; } 
    /// <summary>
    /// Specifies if the collateral that is substituted was posted against the variation margin or the independent amount.
    /// </summary>
    public required CollateralSubstitutionType1Code CollateralSubstitutionType { get; init; } 
    /// <summary>
    /// Identifies the standard settlement instructions.
    /// </summary>
    public IsoMax140Text? StandardSettlementInstructions { get; init; } 
    /// <summary>
    /// Collateral type is securities.
    /// </summary>
    public SecuritiesCollateral7? SecuritiesCollateral { get; init; } 
    /// <summary>
    /// Collateral type is cash.
    /// </summary>
    public CashCollateral5? CashCollateral { get; init; } 
    /// <summary>
    /// Collateral type is other than securities or cash for example letter of credit.
    /// </summary>
    public OtherCollateral7? OtherCollateral { get; init; } 
    /// <summary>
    /// Provides details on the identification of previously sent and/or received message(s), in case of updated substitution request.
    /// </summary>
    public Reference17? LinkedReferences { get; init; } 
    
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
        writer.WriteStartElement(null, "CollSbstitnSeq", xmlNamespace );
        writer.WriteValue(CollateralSubstitutionSequence.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SbstitnRqrmnt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(SubstitutionRequirement)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CollSbstitnTp", xmlNamespace );
        writer.WriteValue(CollateralSubstitutionType.ToString()); // Enum value
        writer.WriteEndElement();
        if (StandardSettlementInstructions is IsoMax140Text StandardSettlementInstructionsValue)
        {
            writer.WriteStartElement(null, "StdSttlmInstrs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(StandardSettlementInstructionsValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (SecuritiesCollateral is SecuritiesCollateral7 SecuritiesCollateralValue)
        {
            writer.WriteStartElement(null, "SctiesColl", xmlNamespace );
            SecuritiesCollateralValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashCollateral is CashCollateral5 CashCollateralValue)
        {
            writer.WriteStartElement(null, "CshColl", xmlNamespace );
            CashCollateralValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherCollateral is OtherCollateral7 OtherCollateralValue)
        {
            writer.WriteStartElement(null, "OthrColl", xmlNamespace );
            OtherCollateralValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LinkedReferences is Reference17 LinkedReferencesValue)
        {
            writer.WriteStartElement(null, "LkdRefs", xmlNamespace );
            LinkedReferencesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CollateralSubstitution5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
