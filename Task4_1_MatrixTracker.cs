using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    public class MatrixTracker<T>
    {
        private DiagonalMatrix<T> matrix;
        private EventArgsChanged<T> lastChange;

        public MatrixTracker(DiagonalMatrix<T> matrix)
        {
            this.matrix = matrix;
            matrix.ElementChanged += Matrix_ElementChanged;
        }

        public void Undo()
        {
            if (lastChange != null)
            {
                matrix[lastChange.Row, lastChange.Column] = lastChange.OldValue;
                lastChange = null;
            }
        }

        private void Matrix_ElementChanged(object sender, EventArgsChanged<T> elementOne)
        {
            lastChange = elementOne;
        }
    }
}
