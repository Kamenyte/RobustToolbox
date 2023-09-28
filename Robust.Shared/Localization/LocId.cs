﻿using System;
using Robust.Shared.Serialization;
using Robust.Shared.Serialization.TypeSerializers.Implementations;

namespace Robust.Shared.Localization;

/// <summary>
///     Wrapper type for a localization string id.
/// </summary>
/// <param name="Id">The id of the localization string.</param>
/// <remarks>
///     This will be automatically validated by <see cref="LocIdSerializer"/> if used in data fields.</remarks>
/// <seealso cref="Loc.GetString(string)"/>
[Serializable, NetSerializable]
public readonly record struct LocId(string Id)
{
    public static implicit operator string(LocId locId)
    {
        return locId.Id;
    }

    public static implicit operator LocId(string id)
    {
        return new LocId(id);
    }
}
