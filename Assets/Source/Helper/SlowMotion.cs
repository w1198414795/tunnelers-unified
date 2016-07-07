﻿// vim:set ts=4 sw=4 sts=4 noet:
//
//  SlowMotion.cs is part of Tunnelers: Unified
//  <https://github.com/VacuumGames/tunnelers-unified/>.
//
//  Copyright (c) 2016 Juraj Fiala <doctorjellyface@riseup.net>
//
//  Tunnelers: Unified is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  Tunnelers: Unified is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with Tunnelers: Unified.  If not, see <http://www.gnu.org/licenses/>.
//

using UnityEngine;

public class SlowMotion: MonoBehaviour {

	public float slowness = 0.02f;

	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {

			if (Time.timeScale == 1.0f)
				Time.timeScale = slowness;
			else
				Time.timeScale = 1.0f;

			Time.fixedDeltaTime = 0.02f * Time.timeScale;
		}
	}
}
