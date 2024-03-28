using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace W2D3.Exs.Tetris
{
	public interface IActiveTetrisPieceProvider
	{
		TetrisPiece ActivePiece { get; }

	}
}
