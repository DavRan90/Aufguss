window.quillInterop = {
    editors: {},

    create: function (id) {
        const container = document.getElementById(id);
        if (!container) return;

        // Remove all existing Quill toolbars globally
        document.querySelectorAll('div.ql-toolbar.ql-snow').forEach(tb => tb.remove());

        // Remove previous editor instance if exists
        if (this.editors[id]) {
            this.destroy(id);
        }

        // Create new editor
        const quill = new Quill(container, { theme: 'snow' });
        this.editors[id] = quill;
    },

    getHtml: function (id) {
        return this.editors[id]?.root.innerHTML ?? "";
    },

    setHtml: function (id, html) {
        const quill = this.editors[id];
        if (!quill) return;

        quill.clipboard.dangerouslyPasteHTML(html);
    },

    destroy: function (id) {
        const quill = this.editors[id];
        if (!quill) return;

        const container = document.getElementById(id);
        if (container) {
            while (container.firstChild) {
                container.removeChild(container.firstChild);
            }
        }

        delete this.editors[id];
    }
};
