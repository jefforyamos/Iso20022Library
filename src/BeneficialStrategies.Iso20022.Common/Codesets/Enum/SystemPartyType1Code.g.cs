﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SystemPartyType1Code.  ISO2002 ID# _kp6thO5NEeCisYr99QEiWA_-1109986721.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of the party within a system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_kp6thO5NEeCisYr99QEiWA_-1109986721")]
[Description(@"Specifies the type of the party within a system.")]
[DerivedFrom(typeof(SystemPartyTypeCode))]
public enum SystemPartyType1Code
{
    /// <summary>
    /// Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records.
    /// Encoded/decoded by serializers as "CentralSecuritiesDepository".
    /// </summary>
    [EnumMember(Value = "CSDY")]
    [IsoId("_kqEegO5NEeCisYr99QEiWA_1337153248")]
    [Description(@"Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records.")]
    CentralSecuritiesDepository,
    
    /// <summary>
    /// As system participant, the national central bank is the principal monetary authority of a nation and performs several key functions, including issuing currency and regulating the supply of credit in the economy.
    /// Encoded/decoded by serializers as "NationalCentralBank".
    /// </summary>
    [EnumMember(Value = "NCBK")]
    [IsoId("_kqEege5NEeCisYr99QEiWA_-1879793710")]
    [Description(@"As system participant, the national central bank is the principal monetary authority of a nation and performs several key functions, including issuing currency and regulating the supply of credit in the economy.")]
    NationalCentralBank,
    
    /// <summary>
    /// National central bank or a private bank used to settle the cash leg of securities settlements: it provides the cash account to support the settlement of the securities transactions of another financial institution in central bank money (CeBM).
    /// Encoded/decoded by serializers as "PaymentBank".
    /// </summary>
    [EnumMember(Value = "PMBK")]
    [IsoId("_kqEegu5NEeCisYr99QEiWA_1622437669")]
    [Description(@"National central bank or a private bank used to settle the cash leg of securities settlements: it provides the cash account to support the settlement of the securities transactions of another financial institution in central bank money (CeBM).")]
    PaymentBank,
    
    /// <summary>
    /// Participant of a central securities depositary defined within the system, for which the account holder is the central securities depository.
    /// Encoded/decoded by serializers as "CentralSecuritiesDepositoryParticipant".
    /// </summary>
    [EnumMember(Value = "CSDP")]
    [IsoId("_kqEeg-5NEeCisYr99QEiWA_-1911764474")]
    [Description(@"Participant of a central securities depositary defined within the system, for which the account holder is the central securities depository.")]
    CentralSecuritiesDepositoryParticipant,
    
    /// <summary>
    /// Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records.
    /// The infrastructure is external to the system executing the instruction.
    /// Encoded/decoded by serializers as "ExternalCentralSecuritiesDepository".
    /// </summary>
    [EnumMember(Value = "ECSD")]
    [IsoId("_kqEehO5NEeCisYr99QEiWA_373245964")]
    [Description(@"Infrastructure that holds or controls the holding of physical or dematerialised financial instruments belonging to all, or a large portion of, the investors in a securities market. This effects the centralised transfer of ownership of such securities by entries on its books and records. The infrastructure is external to the system executing the instruction.")]
    ExternalCentralSecuritiesDepository,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SystemPartyType1CodeMetadataExtensions
{
    private static readonly SystemPartyType1CodeDropdownSource _dropdownSource = new SystemPartyType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISystemPartyType1CodeDropdownRow GetMetadata(this SystemPartyType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


