Horizontal scrolling the WPF DataGrid with no data example
===

Problem
---

The WPF DataGrid with no data can not scroll horizontally.
This causes problems that can not be displayed if headers are long enough.

![ss1.png](https://raw.githubusercontent.com/wiki/alzybaad/ScrollingDataGridWithNoDataExample/ss1.png)


Solution 1
---

Wrapping the DataGrid by the ScrollViewer, and use the ScrollViewer's scrollbars instead of the DataGrid's ones.
However, this causes significantly slow down of the DataGrid rendering.

![ss2.gif](https://raw.githubusercontent.com/wiki/alzybaad/ScrollingDataGridWithNoDataExample/ss2.gif)


Solution 2
---

Wrapping the DataGrid by the ScrollViewer, and use the ScrollViewer's horizontal scrollbar instead of the DataGrid's one.
However, this causes the vertical scrollbar to disappear unless it scrolls to the right end.

![ss3.gif](https://raw.githubusercontent.com/wiki/alzybaad/ScrollingDataGridWithNoDataExample/ss3.gif)


Solution 3
---

Wrapping the DataGrid by the ScrollViewer, and use the ScrollViewer's horizontal scrollbar instead ofthe  DataGrid's one when the DataGrid has no data.
However, this causes difference of HorizontalOffsets when the DataGrid has data and when the DataGrid has no data.

![ss4.gif](https://raw.githubusercontent.com/wiki/alzybaad/ScrollingDataGridWithNoDataExample/ss4.gif)


Solution 4
---

Wrapping the DataGrid by the ScrollViewer, and use the ScrollViewer's horizontal scrollbar instead of the DataGrid's one when the DataGrid has no data.
Furthermore, handle the OnScrollChanged events and align the HorizontalOffsets of the 2 scroll bars.

![ss5.gif](https://raw.githubusercontent.com/wiki/alzybaad/ScrollingDataGridWithNoDataExample/ss5.gif)
