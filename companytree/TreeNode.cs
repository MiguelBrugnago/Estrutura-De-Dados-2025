using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace companytree
{
    // o T -> o tsao é a especificaçao de um tipo generico (Generics)

    public class TreeNode<T>
    {
        // o atributo Data do tipo generico T armazena o valor de fato do node

        public T Data { get; set; }

        // o atributo Parent referencia o node pai do node atual

        public TreeNode<T> Parent { get; set; }

        // o atributo Children armazena uma lista de nodes filhos do node atual

        public List<TreeNode<T>> Children { get; set; }

        // construtor da classe TreeNode que inicializa os atributos Data, Parent e Children

        public int GetHeight()
        {
            int height = 1;
            TreeNode<T> current = this;
            while (current.Parent != null)
            {
                height++;
                current = current.Parent;
            }
            return height;
        }
    }
}
