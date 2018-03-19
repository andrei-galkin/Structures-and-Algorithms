using System;

namespace DataStructures
{
    public class HashTable<K, V>
    {
        private LinkedList<KeyValuePair<K, V>>[] _items;
        private int _fillFactor = 3;
        private int _size;
        private int _count;

        public int Count { get => _count; private set => _count = value; }

        public HashTable()
        {
            _items = new LinkedList<KeyValuePair<K, V>>[4];
        }

        public void Add(K key, V value)
        {
            var index = GetIndex(key, _items.Length);

            if (_items[index] == null)
            {
                _items[index] = new LinkedList<KeyValuePair<K, V>>();
            }

            foreach (KeyValuePair<K, V> keyValuePair in _items[index])
            {
                if (keyValuePair.Key.Equals(key))
                {
                    throw new Exception("Duplicate key violation.");
                }
            }

            _size++;

            if (NeedToResize())
            {
                ResizeWithHashUpdate();
            }

            index = GetIndex(key, _items.Length);
            if (_items[index] == null)
            {
                _items[index] = new LinkedList<KeyValuePair<K, V>>();
            }

            _items[index].Append(new KeyValuePair<K, V>(key, value));
            _count++;
        }

        public void Delete(K key)
        {
            var index = GetIndex(key, _items.Length);

            if (_items[index] != null)
            {
                KeyValuePair<K, V> itemToRemove = FindElement(_items[index], key);

                if (itemToRemove == null) return;

                _items[index].Delete(itemToRemove);
                _size--;
                _count--;
            }
            else
            {
                throw new Exception("Value does not exist.");
            }
        }

        public V Get(K key)
        {
            var index = GetIndex(key, _items.Length);
            var item = FindElement(_items[index], key);
            return item != null ? item.Value : default(V);
        }

        private KeyValuePair<K, V> FindElement(LinkedList<KeyValuePair<K, V>> items, K key)
        {
            foreach (KeyValuePair<K, V> item in items)
            {
                if (item.Key.Equals(key))
                {
                    return item;
                }
            }

            return default(KeyValuePair<K, V>);
        }

        private void ResizeWithHashUpdate()
        {
            _fillFactor *= 2;
            var newItems = new LinkedList<KeyValuePair<K, V>>[_items.Length * 2];

            foreach (LinkedList<KeyValuePair<K, V>> item in _items)
            {
                if (item != null)
                {
                    foreach (KeyValuePair<K, V> value in item)
                    {
                        var index = GetIndex(value.Key, newItems.Length);

                        if (newItems[index] == null)
                        {
                            newItems[index] = new LinkedList<KeyValuePair<K, V>>();
                        }

                        newItems[index].Append(new KeyValuePair<K, V>(value.Key, value.Value));
                    }
                }
            }

            _items = newItems;
        }

        private int GetIndex(K key, int length)
        {
            var hash = key.GetHashCode();
            var pos = Math.Abs(hash % length);
            return pos;
        }

        private bool NeedToResize()
        {
            return _size >= _fillFactor;
        }
    }
}
